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

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class TaskList : Form
    {
        IEnumerable<m.TaskItemDetail> _FinishedTasks;

        public TaskList()
        {
            InitializeComponent();
            SetupControls();
            RefreshData();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvTask.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search task...");
            cboPeriod.DataSource = d.Period.Get();
            CheckCustomPeroid();
            cboPeriod.SelectedValueChanged += cboPeriod_SelectedValueChanged;
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

            _FinishedTasks = d.TaskItem.GetByStatus(m.TStatus.Finish, period);
            dgvTask.DataSource = _FinishedTasks;
        }

        #endregion

        private void cboPeriod_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckCustomPeroid();
            RefreshData();
        }

        private void CheckCustomPeroid()
        {
            var pId = cboPeriod.SelectedValue as int?;

            dtpStartDate.Visible
            = dtpEndDate.Visible
            = lblStartDate.Visible
            = lblEndDate.Visible
            = btnSearch.Visible
            = pId == 4;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var list = _FinishedTasks.Where(t =>
                t.taskName.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                dgvTask.DataSource = list;
            }
            else
                dgvTask.DataSource = _FinishedTasks;
        }
    }
}
