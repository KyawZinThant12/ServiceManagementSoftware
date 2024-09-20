using Microsoft.Reporting.WinForms;
using ServiceManagementSoftware.Components;
using ServiceManagementSoftware.Forms.Reporting;
using ServiceManagementSoftware.Forms.SetupMenu;
using ServiceManagementSoftware.Forms.Utils;
using ServiceManagementSoftware.Helpers;
using ServiceManagementSoftware.Model;
using ServiceManagementSoftware.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using m = Model;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Forms.TaskMenu
{
    public partial class VoucherEntry : ShadowForm
    {
        m.Voucher _voucher;
        BindingList<m.TaskItem> _taskItems;
        BindingList<m.VoucherCharge> _vCharges;
        List<m.Customer> _customerList;
        decimal? oAmount;

        public VoucherEntry(m.Voucher voucher)
        {
            _voucher = voucher;

            InitializeComponent();

            SetUpControls();
            BindData();
        }

        #region "Functions"

        private void SetUpControls()
        {
            dgvTask.AutoGenerateColumns = false;
            dgvRecItem.AutoGenerateColumns = false;

            colNo.HeaderCell.Style.Alignment
                = colQty.HeaderCell.Style.Alignment
                = colItemQty.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleCenter;
            colCost.HeaderCell.Style.Alignment
                = colAmount.HeaderCell.Style.Alignment
                = colItemPrice.HeaderCell.Style.Alignment
                = colItemAmt.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleRight;

            var customers =  _customerList = d.Customer.Get().ToList();
            customers.Insert(0, new m.Customer { customerId = 0, customerName = "None" });
            cboCustomer.DataSource = customers;

            var emps = d.Employee.Get().ToList();
            emps.Insert(0, new m.Employee { empId = 0, empName = "None" });
            cboEmp.DataSource = emps;

            ctrControl.LockStateChanged += (s, e) =>
            {
                // check permission
                bool allow = fn.Permit(FormId.VouLockUnLock).viewAllow;
                if (!allow)
                {
                    MessageBox.Show("You do not have permission.", "Voucher Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                _voucher.locked = e.Locked;
                try
                {
                    d.Voucher.SetLock(_voucher.vId, _voucher.locked);
                    ctrControl.Locked = _voucher.locked;
                }
                catch { }
            };
        }

        private void BindData()
        {
            if (_voucher != null)
            {
                txtVno.Text = _voucher.vNo;
                dtpVdate.Value = _voucher.vDate;
                dtpDueDate.Value = _voucher.dueDate;
                cboCustomer.SelectedValue = _voucher.customerId != null ? _voucher.customerId : 0;
                cboEmp.SelectedValue = _voucher.empId != null ? _voucher.empId : 0;
                txtRemark.Text = _voucher.remark;
                numTolAmt.Value = _voucher.vTol;
                numDisPer.Value = Math.Round(_voucher.disPer, 0);
                numDiscount.Value = _voucher.disAmt;
                numPrePaid.Value = _voucher.preAmt;
                numPostPaid.Value = _voucher.postAmt;
                numBal.Value = _voucher.vBal;
                oAmount = _voucher.preAmt + _voucher.postAmt;

                if (_voucher.status == m.VStatus.Finish)
                    ctrControl.Locked = _voucher.locked;

                btnDelete.Visible = fn.Permit(FormId.VouDel)?.viewAllow ?? false;
            }
            else
            {
                _voucher = new m.Voucher();
                _voucher.vDate = _voucher.preDate = _voucher.postDate = DateTime.Now;
                txtVno.Text = d.Voucher.GenerateVno();
                btnFinish.Visible = btnDelete.Visible = false;
                colFinish.Visible = false;
            }

            if (_voucher != null && _voucher.taskItems != null)
                _taskItems = new BindingList<m.TaskItem>(_voucher.taskItems.ToList());
            else
                _taskItems = new BindingList<m.TaskItem>();
            _taskItems.ListChanged += (s, e) =>
            {
                UpdateTotalAmt();
            };
            dgvTask.DataSource = _taskItems;

            if (_voucher != null && _voucher.voucherCharges != null)
                _vCharges = new BindingList<m.VoucherCharge>(_voucher.voucherCharges.ToList());
            else
                _vCharges = new BindingList<m.VoucherCharge>();
            _vCharges.ListChanged += (s, e) =>
            {
                UpdateTotalAmt();
            };
            dgvRecItem.DataSource = _vCharges;
        }

        private string CheckUserInputDataValid()
        {
            return null;
        }

        private void UpdateTotalAmt()
        {
            numTolAmt.Value = _taskItems.Sum(t => t.amount) + _vCharges.Sum(c => c.amount);
        }

        private void SaveToModel()
        {
            _voucher.vNo = txtVno.Text;
            _voucher.vDate = dtpVdate.Value;

            var cid = cboCustomer.SelectedValue as int?;
            cid = cid > 0 ? cid : null;
            _voucher.customerId = cid;
            _voucher.customer = _customerList.Find(c => c.customerId == _voucher.customerId);

            var eid = cboEmp.SelectedValue as int?;
            eid = eid > 0 ? eid : null;
            _voucher.empId = eid;

            _voucher.remark = txtRemark.Text;
            _voucher.dueDate = dtpDueDate.Value;
            _voucher.vTol = numTolAmt.Value;
            _voucher.disPer = numDisPer.Value;
            _voucher.disAmt = numDiscount.Value;
            _voucher.preAmt = numPrePaid.Value;
            _voucher.postAmt = numPostPaid.Value;
            _voucher.vBal = numBal.Value;
            _voucher.taskItems = _taskItems.ToList();
            _voucher.voucherCharges = _vCharges.ToList();
        }

        private m.VStatus CalculateStatus()
        {
            if (_voucher.taskItems.Count() > 0 && _voucher.vBal == 0) return m.VStatus.Paid;

            return m.VStatus.Pending;
        }

        private bool SaveVoucher(m.VStatus? status = null)
        {
            //string wrnMsg = CheckUserInputDataValid();
            //if (!string.IsNullOrWhiteSpace(wrnMsg))
            //{
            //    MessageBox.Show(wrnMsg, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            SaveToModel();

            if (status != null)
                _voucher.status = (m.VStatus)status;
            else
                _voucher.status = CalculateStatus();
            if (_voucher.status == m.VStatus.Finish)
                _voucher.locked = true;

            try
            {
                if (_voucher.vId == 0)
                {
                    _voucher.vId = d.Voucher.Insert(_voucher);

                    fn.AddActionLog(FormId.VoucherEntry + " (" + _voucher.vNo + ")", m.ActionName.Inserted);
                }
                else
                {
                    d.Voucher.Update(_voucher);

                    fn.AddActionLog(FormId.VoucherEntry + " (" + _voucher.vNo + ")", m.ActionName.Updated);
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occur while saving data."+e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private List<m.VoucherReport> GetVoucherReport(m.Voucher voucher)
        {
            var result = new List<m.VoucherReport>();
            if (voucher.taskItems.Count() == 0)
            {
                result.Add(new m.VoucherReport
                {

                });

                return result;
            }

            var services = voucher.taskItems.Select(t => new m.VoucherReport
            {
                vNo = voucher.vNo,
                amount = t.amount,
                customerName = voucher.customer?.customerName,
                disAmt = voucher.disAmt,
                phoneNo = voucher.customer?.phNo,
                address = voucher.customer?.address,
                postAmt = voucher.postAmt,
                preAmt = voucher.preAmt,
                price = t.cost,
                qty = t.qty,
                remark = voucher.remark,
                taskName = t.task?.taskName,
                vBal = voucher.vBal,
                vDate = voucher.vDate,
                dueDate = voucher.dueDate,
                vTol = voucher.vTol,
                type = "a"
            }).ToList();

            services.AddRange(voucher.voucherCharges.Select(t => new m.VoucherReport
            {
                vNo = voucher.vNo,
                amount = t.amount,
                customerName = voucher.customer?.customerName,
                disAmt = voucher.disAmt,
                phoneNo = voucher.customer?.phNo,
                address = voucher.customer?.address,
                postAmt = voucher.postAmt,
                preAmt = voucher.preAmt,
                price = t.price,
                qty = t.qty,
                remark = voucher.remark,
                taskName = t.charge?.name,
                vBal = voucher.vBal,
                vDate = voucher.vDate,
                dueDate = voucher.dueDate,
                vTol = voucher.vTol,
                type = "b"
            }));

            return services;
        }

        private LocalReport GetPreparedReport()
        {
            var report = new LocalReport();
            if (va.PrinterInfo.PaperSize == PaperSize.Slip)
                report.ReportPath = Path.Combine(Application.StartupPath, @"ReportFiles\Voucher_80.rdlc");
            else
                report.ReportPath = Path.Combine(Application.StartupPath, @"ReportFiles\Voucher_A5.rdlc");

            SaveToModel();
            report.DataSources.Add(new ReportDataSource
            {
                Name = "VoucherReport",
                Value = GetVoucherReport(_voucher)
            });

            report.DataSources.Add(new ReportDataSource
            {
                Name = "BusinessInfo",
                Value = new List<m.BusinessInfo> { va.BusinessInfo }
            });

            return report;
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SaveVoucher())
                DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_voucher.vId == 0 && (_taskItems.Count > 0 || _vCharges.Count > 0))
            {
                if (MessageBox.Show("Are you sure to cancel without saving ?", Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    != DialogResult.Yes)
                    return;
            }


            DialogResult = DialogResult.Cancel;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int eid = _taskItems.LastOrDefault()?.empId ?? 0;
            TaskItemEntry entry = new TaskItemEntry(null, _voucher.locked, eid);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                _taskItems.Add(entry.TItem);
            }
        }

        private void btnAddRecItem_Click(object sender, EventArgs e)
        {
            VChargesEntry entry = new VChargesEntry(null, _voucher.locked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                entry.Vcharge.vId = _voucher.vId;
                _vCharges.Add(entry.Vcharge);
            }
        }

        private void dgvRecItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colItemName.Index)
            {
                var item = dgvRecItem.Rows[e.RowIndex].DataBoundItem as m.VoucherCharge;
                if (item != null)
                {
                    e.Value = item.charge?.name;
                }
            }
        }

        private void dgvTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 
                || e.ColumnIndex == colActionTask.Index 
                || e.ColumnIndex == colFinish.Index) return;

            if (e.ColumnIndex == colNo.Index)
            {
                e.Value = e.RowIndex + 1;
            }
            else if (e.ColumnIndex == colTaskName.Index)
            {
                var t = dgvTask.Rows[e.RowIndex].DataBoundItem as m.TaskItem;
                if (t != null)
                    e.Value = t.task?.taskName;
            }

            // finish task color
            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as m.TaskItem;
            if (task == null) return;
            if (task.status == m.TStatus.Finish)
            {
                e.CellStyle.BackColor
                = e.CellStyle.SelectionBackColor 
                = Color.LightGray;

                e.CellStyle.ForeColor
                = e.CellStyle.SelectionForeColor
                = Color.Black;
            }
        }

        private void dgvRecItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvRecItem.Rows[e.RowIndex].DataBoundItem as m.VoucherCharge;
            if (item == null) return;

            VChargesEntry entry = new VChargesEntry(item, _voucher.locked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                dgvRecItem.Refresh();
                UpdateTotalAmt();
            }
        }

        private void dgvTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as m.TaskItem;
            if (task == null) return;

            TaskItemEntry entry = new TaskItemEntry(task, _voucher.locked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                dgvTask.Refresh();
                UpdateTotalAmt();
            }
        }

        private void dgvRecItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colActionItem.Index || _voucher.locked) return;

            cmsDelete.Tag = e.RowIndex;
            cmsDelete.Show(Cursor.Position);
        }

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _voucher.locked) return;

            if (e.ColumnIndex == colActionTask.Index)
            {
                cmsDelete.Tag = e.RowIndex;
                cmsDelete.Show(Cursor.Position);
            }
            else if (e.ColumnIndex == colFinish.Index)
            {
                var task = dgvTask.CurrentRow?.DataBoundItem as m.TaskItem;
                if (task?.status == m.TStatus.Finish) return;

                cmsFinish.Show(Cursor.Position);
            }
        }

        private void mnuOk_Click(object sender, EventArgs e)
        {
            int index = (int)cmsDelete.Tag;

            if (dgvRecItem.Focused)
            {
                dgvRecItem.Rows.Remove(dgvRecItem.Rows[index]);
            }
            else if (dgvTask.Focused)
            {
                dgvTask.Rows.Remove(dgvTask.Rows[index]);
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            cmsDelete.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerEntry entry = new CustomerEntry(null,false);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                cboCustomer.DataSource = d.Customer.Get();
                cboCustomer.SelectedValue = entry.CustomerId;
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmployeeEntry entry = new EmployeeEntry(null,false);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                cboEmp.DataSource = d.Employee.Get();
                cboEmp.SelectedValue = entry.EmpId;
            }
        }

        private void cboCustomer_Leave(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue == null)
                cboCustomer.SelectedValue = 0;
        }

        private void cboEmp_Leave(object sender, EventArgs e)
        {
            if (cboEmp.SelectedValue == null)
                cboEmp.SelectedValue = 0;
        }

        private void numTolAmt_ValueChanged(object sender, EventArgs e)
        {
            numNetAmt.Value = numTolAmt.Value - numDiscount.Value;
            numBal.Value = Math.Max(numNetAmt.Value - (numPrePaid.Value + numPostPaid.Value), 0);
        }

        private void numPrePaid_ValueChanged(object sender, EventArgs e)
        {
            numBal.Value = Math.Max(numNetAmt.Value - (numPrePaid.Value + numPostPaid.Value), 0);
        }

        private void dgvTask_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colActionTask.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources.delete);
            }
            else if (e.ColumnIndex == colFinish.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources._checked);
            }
        }

        private void dgvRecItem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colActionItem.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources.delete);
            }
        }

        private void btnPrint_ButtonClick(object sender, EventArgs e)
        {
            if (!SaveVoucher())
                return;

            try
            {
                var report = GetPreparedReport();
                report.PrintToPrinter();

                //if (!string.IsNullOrWhiteSpace(va.PrinterInfo.PrinterName))
                //    report.PrintSettings.ShowDialog = false;

                //report.PrintSettings.Copies = va.PrinterInfo.Copies;

                //report.Print();

                // save printer name
                //if (report.PrintSettings.ShowDialog)
                //{
                //    va.PrinterInfo.PrinterName = report.PrintSettings.Printer;
                //    fn.SetRegistryValue(RegistryId.PrinterInfo,
                //        JsonConvert.SerializeObject(va.PrinterInfo));
                //}

                fn.AddActionLog(FormId.VoucherEntry + " (" + _voucher.vNo + ")", m.ActionName.Printed);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur while printing voucher.", "Print voucher",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuPreview_Click(object sender, EventArgs e)
        {
            if (!SaveVoucher())
                return;

            try
            {
                var report = GetPreparedReport();
                PrintPreview preview = new PrintPreview(report);
                preview.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur while previewing voucher.", "Preview voucher",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            var tasks = d.TaskItem.GetPendingTaskByVoucher(_voucher.vId);
            if (tasks.Count() > 0)
            {
                MessageBox.Show("All task must be finished !", "Finish",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (numBal.Value > 0)
            {
                MessageBox.Show("Balance must be zero !", "Finish", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (SaveVoucher(m.VStatus.Finish))
                DialogResult = DialogResult.OK;
        }

        private void dgvTask_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvRecItem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void mnuConfirm_Click(object sender, EventArgs e)
        {
            var task = dgvTask.CurrentRow?.DataBoundItem as m.TaskItem;
            if (task == null) return;

            try
            {
                long vId = d.TaskItem.FinishTask(task.taskItemId);
                task.status = m.TStatus.Finish;

                dgvTask.Refresh();
            }
            catch
            {
                MessageBox.Show("Error occur while updating data.",
                    "Update data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuCancelConfirm_Click(object sender, EventArgs e)
        {
            cmsFinish.Close();
        }

        private void btnPreDate_Click(object sender, EventArgs e)
        {
            DateEntry entry = new DateEntry();
            entry.SelectedDate = _voucher.preDate;
            entry.StartPosition = FormStartPosition.Manual;
            entry.Location = btnPreDate.PointToScreen(btnPreDate.Location);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                _voucher.preDate = entry.SelectedDate;
            }
        }

        private void btnPostDate_Click(object sender, EventArgs e)
        {
            DateEntry entry = new DateEntry();
            entry.SelectedDate = _voucher.postDate;
            entry.StartPosition = FormStartPosition.Manual;
            entry.Location = btnPostDate.PointToScreen(btnPostDate.Location);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                _voucher.postDate = entry.SelectedDate;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the voucher ?", "Delete Voucher",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;

            var entry = new PasswordEntry();
            if (entry.ShowDialog() != DialogResult.OK)
                return;

            _voucher.deleted = true;

            if (SaveVoucher())
            {
                fn.AddActionLog(FormId.VoucherEntry + " (" + _voucher.vNo + ")", m.ActionName.Deleted);

                DialogResult = DialogResult.OK;
            }
        }

        private void numDisPer_ValueChanged(object sender, EventArgs e)
        {
            numDiscount.Value = numTolAmt.Value * numDisPer.Value / 100;
        }
    }
}
