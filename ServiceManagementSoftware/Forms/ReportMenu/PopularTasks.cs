using ServiceManagementSoftware.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using m = Model;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class PopularTasks : Form
    {
        public PopularTasks()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvTask.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCount.HeaderCell.Style.Alignment
                = colAmt.HeaderCell.Style.Alignment
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

            var list = d.Report.GetTaskItemCounts(period);
            dgvTask.DataSource = new SortableBindingList<m.TaskItemCount>(list.ToList());
            lblTotal.Label = lblTotal.Tag as string + list.Sum(t => t.tolAmt).ToString("N0");
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.PopularTask_Period);
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

        private void PopularTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.PopularTask_Period, period);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvTask, "Popular Tasks");
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
