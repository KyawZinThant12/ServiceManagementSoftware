using ServiceManagementSoftware.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fn = ServiceManagementSoftware.Shared.Functions;
using d = DataAccess;
using m = Model;

namespace ServiceManagementSoftware.Forms.CashMenu
{
    public partial class CashList : Form
    {
        public CashList()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvCash.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAmt.HeaderCell.Style.Alignment
                = colAmt.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleRight;

            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeriod();

            cboType.DataSource = Enum.GetValues(typeof(m.CType));
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

            var list = d.Cash.Get(period);

            if (cboType.SelectedItem != null)
            {
                var type = (m.CType)cboType.SelectedItem;
                list = list.Where(c => c.type == type);
            }

            dgvCash.DataSource = new SortableBindingList<m.Cash>(list.ToList());
            lblTotal.Text = lblTotal.Tag as string + list.Sum(t => t.amount).ToString("N0");
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.Cash_Period);
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

            cboType.SelectedValueChanged += (sd, er) =>
            {
                RefreshData();
            };
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvCash_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCash.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }

        private void CashList_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.Cash_Period, period);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m.CType type = m.CType.Income;
            if (cboType.SelectedItem != null)
                type = (m.CType)cboType.SelectedItem;

            CashEntry entry = new CashEntry(null, type);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void dgvCash_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cash = dgvCash.Rows[e.RowIndex].DataBoundItem as m.Cash;
            if (cash == null) return;

            CashEntry entry = new CashEntry(cash, cash.type);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
