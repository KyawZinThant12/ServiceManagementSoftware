﻿using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceManagementSoftware.Components;
using ServiceManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using d = DataAccess;
using Excel = Microsoft.Office.Interop.Excel;
using m = Model;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Shared
{
    public class Functions
    {
        public static void ShowForm<T>()
        {
            if (va.FrmMain.pnlMain.Controls.Count > 0)
            {
                var exForm = va.FrmMain.pnlMain.Controls[0] as Form;
                if (exForm.Name == typeof(T).Name)
                    return;

                exForm.Close();
            }

            var from = Activator.CreateInstance<T>() as Form;
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            va.FrmMain.pnlMain.Controls.Add(from);
            from.Show();
        }

        public static object GetRegistryValue(string name)
        {
            using (var key = Registry.CurrentUser.OpenSubKey(va.RegistryPath))
            {
                return key?.GetValue(name.ToString());
            }
        }

        public static void SetRegistryValue(string name, object value)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(va.RegistryPath))
            {
                key?.SetValue(name.ToString(), value);
            }
        }

        public static void DeleteRegistryValue(string name)
        {
            using (var key = Registry.CurrentUser.OpenSubKey(va.RegistryPath, true))
            {
                key?.DeleteValue(name.ToString());
            }
        }

        public static T GetUserStore<T>(StoreId storeId)
        {
            var storeValues = GetRegistryValue(RegistryId.UserStore);

            if (storeValues == null) return default(T);

            var stores = JsonConvert.DeserializeObject<IEnumerable<Model.UserStore>>(storeValues.ToString());

            var value = stores.FirstOrDefault(s => s.storeId == storeId)?.value as JObject;

            if (value == null) return default(T);

            return value.ToObject<T>();
        }

        public async static void SetUserStoreAsync(StoreId storeId, object value)
        {
            await Task.Run(() =>
            {
                var stores = Enumerable.Empty<Model.UserStore>();

                var storeValues = GetRegistryValue(RegistryId.UserStore);

                if (storeValues != null)
                    stores = JsonConvert.DeserializeObject<IEnumerable<Model.UserStore>>(storeValues.ToString());

                var store = stores.FirstOrDefault(s => s.storeId == storeId);

                if (store == null)
                {
                    store = new Model.UserStore { storeId = storeId };

                    var temp = stores.ToList();
                    temp.Add(store);
                    stores = temp;
                }

                store.value = value;

                SetRegistryValue(RegistryId.UserStore, JsonConvert.SerializeObject(stores));
            });
        }

        public static string GetConString(string serverName, string uname, string pwd, string dbName)
        {
            return $@"Data Source={serverName};
                    User ID={uname};
                    Password={pwd};
                    Initial Catalog={dbName};";
        }

        public static async Task<bool> IsConStringValid(string conString, CancellationToken token)
        {
            try
            {
                using (var con = new SqlConnection(conString))
                    await con.OpenAsync(token);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void PaintButtonImage(DataGridViewCellPaintingEventArgs e, Image img)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            var w = img.Width;
            var h = img.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(img, new Rectangle(x, y, w, h));
            e.Handled = true;
        }

        public static m.AppPermission Permit(string formId)
        {
            return va.Permissions.Find(p => p.formId == formId) ?? new m.AppPermission();
        }

        public static bool IsAllSetupPermit()
        {
            return va.Permissions.Any(p => p.appForm.type == 1 && p.viewAllow);
        }

        public static bool IsAllFormPermit()
        {
            return va.Permissions.Any(p => p.appForm.type == 2 && p.viewAllow);
        }

        public static void LockForm(Form form, bool locked)
        {
            // lock textbox
            foreach (var txt in GetControls<TextBox>(form.Controls))
                txt.ReadOnly = locked;

            // lock button
            foreach (var btn in GetControls<Button>(form.Controls))
                btn.Enabled = !locked;

            // lock combo
            foreach (var combo in GetControls<ComboBox>(form.Controls))
                combo.Enabled = !locked;

            // lock datetimepicker
            foreach (var picker in GetControls<DateTimePicker>(form.Controls))
                picker.Enabled = !locked;

            // lock numericupdown
            foreach (var num in GetControls<NumericUpDown>(form.Controls))
                num.Enabled = !locked;

            // lock gridview
            foreach (var grid in GetControls<DataGridView>(form.Controls))
                grid.ReadOnly = locked;

            // lock checkbox
            foreach (var check in GetControls<CheckBox>(form.Controls))
                check.Enabled = !locked;

            // lock radio
            foreach (var radio in GetControls<RadioButton>(form.Controls))
                radio.Enabled = !locked;
        }

        public static List<T> GetControls<T>(Control.ControlCollection controls)
        {
            var list = new List<T>();

            foreach (Control ctr in controls)
            {
                if (ctr.Controls.Count > 0)
                {
                    list.AddRange(ctr.Controls.OfType<T>().Where(c => (c as Control).Tag.ToBool() == false));

                    list.AddRange(GetControls<T>(ctr.Controls));
                }
            }

            return list;
        }

        public static bool AddActionLog(string name, m.ActionName actionName)
        {
            try
            {
                d.ActionLog.Insert(new m.ActionLog
                {
                    name = name,
                    actionName = actionName,
                    actionBy = va.CurrentUser.userId,
                    actionDate = DateTime.Now
                });

                return true;
            }
            catch { }

            return false;
        }

        static WaitingDialog waiting;
        public static void ShowLoading(Form form, string label)
        {
            waiting = new WaitingDialog(label);
            form.BeginInvoke((MethodInvoker)(()=>
            {
                waiting.ShowDialog();
            }));
        }

        public static void HideLoading(Form form)
        {
            form.BeginInvoke((MethodInvoker)(() =>
            {
                waiting?.Close();
            }));
        }

        public static async Task ExportToExcelAsync(Form form, DataGridView dgv, string fileName)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Documents (*xlsx)|*xlsx";
            dialog.FileName = fileName + ".xlsx";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            ShowLoading(form, "Exporting...");

            bool success = false;
            await Task.Run(() =>
            {
                try
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Excel.Application();
                    xlApp.DisplayAlerts = false;
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    for (int x = 1; x < dgv.Columns.Count + 1; x++)
                    {
                        xlWorkSheet.Cells[1, x] = dgv.Columns[x - 1].HeaderText;
                    }

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    xlWorkBook.SaveAs(dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    ReleaseObject(xlWorkSheet);
                    ReleaseObject(xlWorkBook);
                    ReleaseObject(xlApp);

                    success = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occur while exporting excel file.", "Export Excel", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            HideLoading(form);

            if (!success || !File.Exists(dialog.FileName)) return;
            
            if (MessageBox.Show(
                    "Data exported successfully. Do you want to open exported excel file ?",
                    "Export Excel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            
            System.Diagnostics.Process.Start(dialog.FileName);
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
        }

        public static ControlInfo GetControlInfo(object tag)
        {
            var info = new ControlInfo();

            string data = tag as string;
            if (data == null)
                return info;

            var values = data.Split('|');
            foreach (string value in values)
            {
                var dict = value.Split(':');
                if (dict.Length != 2) continue;

                if (dict[0] == "1")
                    info.langId = dict[1];
                else if (dict[0] == "2")
                    info.nLock = bool.Parse(dict[1]);
            }

            return info;
        }

        public static void ChangeLang(Control control)
        {
            if (control.Tag != null)
            {
                var info = GetControlInfo(control.Tag);
                if (!string.IsNullOrWhiteSpace(info.langId))
                {
                    control.Font = new Font(va.SelectedFont, 11);
                    control.Text = Helpers.LangHelper.GetLangString(info.langId);
                }
            }
            
            foreach (Control ctr in control.Controls)
            {
                ChangeLang(ctr);
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public static void SetTextboxHint(TextBox textbox, string hintText)
        {
            SendMessage(textbox.Handle, 0x1501, 1, hintText);
        }
    }
}
