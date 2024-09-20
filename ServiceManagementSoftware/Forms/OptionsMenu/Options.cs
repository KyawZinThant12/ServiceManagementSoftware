using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class Options : Form
    {
        Button[] tabs;
        Panel[] pnls;

        public Options()
        {
            InitializeComponent();

            tabs = new Button[] { btnGeneral, btnDatabase, btnPrinter };
            pnls = new Panel[] { pnlGeneral, pnlDatabase, pnlPrinter };

            this.FormClosed += (s, e) =>
            {
                if (pnlTabpage.Controls.Count > 0)
                {
                    (pnlTabpage.Controls[0] as Form)?.Close();
                }
            };
        }

        #region "Functions"

        private void SetActivePage(Button button, Panel panel)
        {
            button.BackColor = pnlTabpage.BackColor;
            button.Enabled = false;
            panel.Visible = true;

            foreach (var btn in tabs)
            {
                if (btn != button)
                {
                    btn.BackColor = Color.LightGray;
                    btn.Enabled = true;
                }
            }

            foreach (var pnl in pnls)
            {
                if (pnl != panel)
                {
                    pnl.Visible = false;
                }
            }
        }

        private void ShowTabPage<T>(params object[] values)
        {
            if (pnlTabpage.Controls.Count > 0)
            {
                var exForm = pnlTabpage.Controls[0] as Form;
                if (exForm.Name == typeof(T).Name)
                    return;

                exForm.Close();
            }

            var from = Activator.CreateInstance(typeof(T), values) as Form;
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            pnlTabpage.Controls.Add(from);
            from.Show();
        }

        #endregion

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SetActivePage(btnGeneral, pnlGeneral);
            ShowTabPage<GeneralOptions>();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            SetActivePage(btnDatabase, pnlDatabase);
            ShowTabPage<DbManagement>();
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            SetActivePage(btnPrinter, pnlPrinter);
            ShowTabPage<PrinterOption>();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            (tabs.ElementAtOrDefault(0) as Button)?.PerformClick();
        }
    }
}
