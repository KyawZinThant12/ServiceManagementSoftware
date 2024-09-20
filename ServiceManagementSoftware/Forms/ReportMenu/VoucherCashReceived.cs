using ServiceManagementSoftware.Helpers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class VoucherCashReceived : Form
    {
        readonly int ALL_CUS_ID = -1;
        readonly int NA_CUS_ID = -2;

        public VoucherCashReceived()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvTask.AutoGenerateColumns = false;
            colGtol.HeaderCell.Style.Alignment
                = colRamo.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleRight;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeroid();

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
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.VhCaRe_Period);
            if (period == null) return;

            cboPeriod.SelectedValue = period.periodId;
            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;
        }

        private void RefreshData()
        {
            var period = cboPeriod.SelectedItem as m.Period;
            var cId = cboCustomer.SelectedValue as int?;
            if (period == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            var list = d.Report.GetVCashReceived(period);

            if (cId == NA_CUS_ID)
                cId = null;

            if (cId != ALL_CUS_ID)
                list = list.Where(l => l.customerId == cId);

            dgvTask.DataSource = new SortableBindingList<m.VoucherAmount>(list.ToList());

            lblReceivedAmt.Text =  ((int)list.Sum(l => l.recAmt)==0)?"":((int)list.Sum(l => l.recAmt)).ToString("N0");
            lblNetAmt.Text = ((int)list.Sum(l => l.vTol) == 0) ? "" : ((int)list.Sum(l => l.vTol)).ToString("N0");
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

        private void cboCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void VoucherCashReceived_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.VhCaRe_Period, period);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvTask, "Voucher Cash Received");
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
