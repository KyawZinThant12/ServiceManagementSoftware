﻿using System;
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
using ServiceManagementSoftware.Forms.TaskMenu;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class VoucherList : Form
    {
        readonly int ALL_CUS_ID = -1;
        readonly int NA_CUS_ID = -2;

        public VoucherList()
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
                = colRamo.HeaderCell.Style.Alignment
                = colBalance.HeaderCell.Style.Alignment
                = colNetAmount.HeaderCell.Style.Alignment
                = colReceivedAmt.HeaderCell.Style.Alignment
                = DataGridViewContentAlignment.MiddleRight;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

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

            cboStatus.SelectedIndex = 0;

            cboPeriod.SelectedValueChanged += cboPeriod_SelectedValueChanged;
            cboCustomer.SelectedValueChanged += cboCustomer_SelectedValueChanged;
            cboStatus.SelectedValueChanged += cboStatus_SelectedValueChanged;
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.AList_Period);
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
            var cId = cboCustomer.SelectedValue as int?;
            if (period == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            m.VStatus? vstat = null;
            if (cboStatus.SelectedIndex == 1)
                vstat = m.VStatus.Pending;
            else if (cboStatus.SelectedIndex == 2)
                vstat = m.VStatus.Paid | m.VStatus.Finish;

            var list= d.Voucher.GetByCustomerStatus(new m.PeriodCusStatus
            {
                periodId = period.periodId,
                periodName = period.periodName,
                startDate = period.startDate,
                endDate = period.endDate,
                customerId = (cId == NA_CUS_ID ? null : cId),
                status = vstat
            });

            dgvVoucher.DataSource = new SortableBindingList<m.VoucherAmount>(list.ToList());

            //lblTotal.Label = lblTotal.Tag + data.Sum(l => l.recAmt).ToString("N0");
            lblTotal.Text = ((int)list.Sum(v => v.vTol) == 0) ? "0" : ((int)list.Sum(v => v.vTol)).ToString("N0");
            lblDiscount.Text = ((int)list.Sum(v => v.disAmt) == 0) ? "0" : ((int)list.Sum(v => v.disAmt)).ToString("N0");
            lblNetAmount.Text = ((int)list.Sum(v => v.netAmt) == 0) ? "0" : ((int)list.Sum(v => v.netAmt)).ToString("N0");
            lblReceived.Text = ((int)list.Sum(v => v.recAmt) == 0) ? "0" : ((int)list.Sum(v => v.recAmt)).ToString("N0");
            lblBalance.Text = ((int)list.Sum(v => v.vBal) == 0) ? "0" : ((int)list.Sum(v => v.vBal)).ToString("N0");
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

        private void cboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void VoucherList_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.AList_Period, period);
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            await fn.ExportToExcelAsync(this, dgvVoucher, "Vouchers");
        }

        private void dgvVoucher_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVoucher.Rows)
            {
                row.Cells[colNo.Index].Value = row.Index + 1;
            }
        }

        private void dgvVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var data = dgvVoucher.Rows[e.RowIndex].DataBoundItem as m.VoucherAmount;
            if (data == null) return;

            var entry = new VoucherEntry(d.Voucher.Get(data.vId));
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
