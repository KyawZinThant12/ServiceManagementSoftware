﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ServiceManagementSoftware.Helpers;
using ServiceManagementSoftware.Forms.TaskMenu;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.HomeMenu
{
    public partial class UnfinishedVouchers : Form
    {
        IEnumerable<m.VoucherAmount> _vouchers;

        public UnfinishedVouchers()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
        }

        #region "Functions"

        private void SetupControls()
        {
            dgvVoucher.AutoGenerateColumns = false;
            colGtol.HeaderCell.Style.Alignment
                = colDiscount.HeaderCell.Style.Alignment
                = colNetAmt.HeaderCell.Style.Alignment
                = colRamo.HeaderCell.Style.Alignment
                = colBalance.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.TopRight;

            fn.SetTextboxHint(txtSearch, "Search Voucher No and Customer");
        }

        private void RefreshData()
        {
            _vouchers = d.Voucher.GetByCustomerStatus(new m.PeriodCusStatus
            {
                customerId = -1,
                periodId = 3,
                status = m.VStatus.Pending | m.VStatus.Paid
            });

            FilterAndBindData();
        }

        private void FilterAndBindData()
        {
            var list = _vouchers;
            if (dtpVdate.Checked)
                list = list.Where(v => v.vDate.Date == dtpVdate.Value.Date);

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string text = txtSearch.Text.ToLower();
                list = list.Where(v => v.vNo.ToLower().Contains(text)
                || (v.customerName?.ToLower().Contains(text) ?? false));
            }

            dgvVoucher.DataSource = new SortableBindingList<m.VoucherAmount>(list.ToList());

            lblTotal.Text = ((int)list.Sum(v => v.vTol) == 0) ? "0" : ((int)list.Sum(v => v.vTol)).ToString("N0");
            lblDiscount.Text = ((int)list.Sum(v => v.disAmt)==0)?"0": ((int)list.Sum(v => v.disAmt)).ToString("N0");
            lblNetAmt.Text = ((int)list.Sum(v => v.netAmt)==0)?"0": ((int)list.Sum(v => v.netAmt)).ToString("N0");
            lblReceived.Text = ((int)list.Sum(v => v.recAmt)==0)?"0":((int)list.Sum(v => v.recAmt)).ToString("N0");
            lblBalance.Text = ((int)list.Sum(v => v.vBal)==0)?"0":((int)list.Sum(v => v.vBal)).ToString("N0");
        }

        #endregion

        private void dtpVdate_ValueChanged(object sender, EventArgs e)
        {
            FilterAndBindData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterAndBindData();
        }

        private void dgvVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var obj = dgvVoucher.Rows[e.RowIndex].DataBoundItem as m.VoucherAmount;
            if (obj == null) return;

            var vouher = d.Voucher.Get(obj.vId);
            VoucherEntry entry = new VoucherEntry(vouher);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fn.ShowForm<Home>();
        }
    }
}
