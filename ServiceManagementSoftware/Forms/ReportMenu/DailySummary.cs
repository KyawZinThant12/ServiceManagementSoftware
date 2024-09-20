using ServiceManagementSoftware.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using m = Model;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class DailySummary : Form
    {
        public DailySummary()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvService.AutoGenerateColumns = dgvStock.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment
                = colQty.HeaderCell.Style.Alignment
                = colSQty.HeaderCell.Style.Alignment
                = colSNo.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleCenter;
            
            colPrice.HeaderCell.Style.Alignment
                = colAmt.HeaderCell.Style.Alignment
                = colSPrice.HeaderCell.Style.Alignment
                = colSAmt.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleRight;

            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeriod();
        }

        private void RefreshData()
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            var data = d.Report.GetDailySummary(period);
            var services = data.services.Where(s => s.type == "service");
            dgvService.DataSource = new SortableBindingList<m.DSService>(services.ToList());
            lblTolService.Text = "Total Service : " + services.Sum(s => s.amount).ToString("N0");
            var stocks = data.services.Where(d => d.type == "stock");
            dgvStock.DataSource = new SortableBindingList<m.DSService>(stocks.ToList());
            lblTolStock.Text = "Total Stock & Charges : " + stocks.Sum(s => s.amount).ToString("N0");
            lblTolAmt.Text = data.tolAmount.ToString("N0");
            lblDiscount.Text = data.disAmt.ToString("N0");
            lblNetAmt.Text = data.netAmount.ToString("N0");
            lblPreAmt.Text = data.preAmt.ToString("N0");
            lblPostAmt.Text = data.postAmt.ToString("N0");
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.DS_Period);
            if (period == null) return;

            cboPeriod.SelectedValue = period.periodId;
            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;
        }

        private void CheckCustomPeriod()
        {
            var pId = cboPeriod.SelectedValue as int?;

            dtpStartDate.Enabled = dtpEndDate.Enabled = (pId == 4);
        }

        private void SubscribeEvents()
        {
            cboPeriod.SelectedValueChanged += (sd, er) =>
            {
                var period = cboPeriod.SelectedItem as m.Period;
                if (period == null) return;

                dtpStartDate.Value = period.startDate;
                dtpEndDate.Value = period.endDate;

                CheckCustomPeriod();
                RefreshData();
            };
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DailySummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.DS_Period, period);
        }

        private void dgvService_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvService.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }

        private void dgvStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                row.Cells[colSNo.Index].Value = row.Index + 1;
            }
        }
    }
}
