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
    public partial class ActionLogList : Form
    {
        public ActionLogList()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvLog.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeroid();

            var users = d.AppUser.Get().ToList();
            users.Insert(0, new m.AppUser { userId = null, userName = "All" });
            cboUser.DataSource = users;

            cboPeriod.SelectedValueChanged += cboPeriod_SelectedValueChanged;
            cboUser.SelectedValueChanged += cboUser_SelectedValueChanged;
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.VList_Period);
            if (period == null) return;

            cboPeriod.SelectedValue = period.periodId;
            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;
        }

        private void CheckCustomPeroid()
        {
            var pId = cboPeriod.SelectedValue as int?;

            dtpStartDate.Enabled = dtpEndDate.Enabled = (pId == 4);
        }

        private void RefreshData()
        {
            var period = cboPeriod.SelectedItem as m.Period;
            var uId = cboUser.SelectedValue as string;
            if (period == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            var data = d.ActionLog.Get(new m.PeriodUser
            {
                periodId = period.periodId,
                periodName = period.periodName,
                startDate = period.startDate,
                endDate = period.endDate,
                userId = uId
            });

            dgvLog.DataSource = new SortableBindingList<m.ActionLog>(data.ToList());
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

        private void cboUser_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ActionLogList_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.VList_Period, period);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvLog, "Action Log");
        }

        private void dgvLog_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLog.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }
    }
}
