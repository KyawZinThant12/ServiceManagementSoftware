using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;
using ServiceManagementSoftware.Helpers;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class CashReceivedByTask : Form
    {
        readonly int ALL_CUS_ID = -1;
        readonly int NA_CUS_ID = -2;
        readonly int ALL_TASK_ID = -1;

        public CashReceivedByTask()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvTask.AutoGenerateColumns = false;
            colTolAmt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeroid();

            var tasks = d.Task.Get().ToList();
            tasks.Insert(0, new m.Task
            {
                taskId = ALL_TASK_ID,
                taskName = "All"
            });
            cboTask.DataSource = tasks;

            var customers = d.Customer.Get().ToList();
            customers.Insert(0, new m.Customer
            {
                customerId = NA_CUS_ID,
                customerName = "Unknown"
            });
            customers.Insert(0, new m.Customer
            {
                customerId = ALL_CUS_ID,
                customerName = "All"
            });
            cboCustomer.DataSource = customers;

            cboPeriod.SelectedValueChanged += cboPeriod_SelectedValueChanged;
            cboCustomer.SelectedValueChanged += cboCustomer_SelectedValueChanged;
            cboTask.SelectedValueChanged += cboTask_SelectedValueChanged;
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.CaReByTk_Period);
            if (period == null) return;

            cboPeriod.SelectedValue = period.periodId;
            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;
        }

        private void RefreshData()
        {
            var period = cboPeriod.SelectedItem as m.Period;
            var tId = cboTask.SelectedValue as int?;
            var cId = cboCustomer.SelectedValue as int?;
            if (period == null || tId == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            var list = d.Report.GetTaskItemTolAmts(period, (int)tId, cId);

            dgvTask.DataSource = new SortableBindingList<m.TaskItemTolAmt>(list.ToList());

            lblTotal.Label = lblTotal.Tag + list.Sum(l => l.tolAmt).ToString("N0");
        }

        private void CheckCustomPeroid()
        {
            var pId = cboPeriod.SelectedValue as int?;

            dtpStartDate.Enabled = dtpEndDate.Enabled = (pId == 4);
        }

        #endregion

        private void cboPeriod_SelectedValueChanged(object sender, EventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period == null) return;

            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;

            CheckCustomPeroid();
            RefreshData();
        }

        private void cboTask_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cboCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CashReceivedByTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.CaReByTk_Period, period);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvTask, "Cash Received By Task");
        }

        private void dgvTask_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTask.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }
    }
}
