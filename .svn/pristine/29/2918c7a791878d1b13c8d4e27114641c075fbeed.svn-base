using ServiceManagementSoftware.Forms.Utils;
using ServiceManagementSoftware.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using m = Model;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class DelVoucherList : Form
    {
        public DelVoucherList()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvVoucher.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colDate.HeaderCell.Style.Alignment
            //    = DataGridViewContentAlignment.MiddleRight;

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

            var list = d.Report.GetDeletedVoucher(period);
            dgvVoucher.DataSource = new SortableBindingList<m.Voucher>(list.ToList());
            //lblTotal.Label = lblTotal.Tag as string + list.Sum(t => t.tolAmt).ToString("N0");
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.DelV_Period);
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

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvVoucher, "Popular Tasks");
        }

        private void dgvVoucher_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVoucher.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }

        private void DelVoucherList_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.DelV_Period, period);
        }

        private void dgvVoucher_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colRestore.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources._checked);
            }
        }

        private void dgvVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colRestore.Index)
            {
                var entry = new PasswordEntry();
                if (entry.ShowDialog() != DialogResult.OK)
                    return;

                var voucher = dgvVoucher.Rows[e.RowIndex].DataBoundItem as m.Voucher;
                if (voucher == null)
                    return;

                try
                {
                    d.Voucher.SetDelete(voucher.vId, false);

                    RefreshData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occur while saving data.", Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
