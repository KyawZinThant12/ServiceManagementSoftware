using ServiceManagementSoftware.Shared;
using System;
using System.Windows.Forms;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class ReportList : Form
    {
        public ReportList()
        {
            InitializeComponent();

            CheckUserPermissions();
        }

        private void CheckUserPermissions()
        {
            btnVoucherCash.Visible = fn.Permit(FormId.VCashRec).viewAllow;
            btnPopularTask.Visible = fn.Permit(FormId.PopTask).viewAllow;
            btnCashByTask.Visible = fn.Permit(FormId.CashByTask).viewAllow;
            btnVoucher.Visible = fn.Permit(FormId.Voucher).viewAllow;
            btnActionLog.Visible = fn.Permit(FormId.ActionLog).viewAllow;
            btnProfitAndLoss.Visible = fn.Permit(FormId.PNL).viewAllow;
            btnDailySummary.Visible = fn.Permit(FormId.DailySum).viewAllow;
            btnDeletedVchrs.Visible = fn.Permit(FormId.DelVchrs).viewAllow;
        }

        private void btnVoucherCash_Click(object sender, EventArgs e)
        {
            fn.ShowForm<VoucherCashReceived>();
        }

        private void btnPopularTask_Click(object sender, EventArgs e)
        {
            fn.ShowForm<PopularTasks>();
        }

        private void btnCashByTask_Click(object sender, EventArgs e)
        {
            fn.ShowForm<CashReceivedByTask>();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            fn.ShowForm<VoucherList>();
        }

        private void btnActionLog_Click(object sender, EventArgs e)
        {
            fn.ShowForm<ActionLogList>();
        }

        private void btnProfitAndLoss_Click(object sender, EventArgs e)
        {
            fn.ShowForm<ProfitAndLoss>();
        }

        private void btnDailySummary_Click(object sender, EventArgs e)
        {
            fn.ShowForm<DailySummary>();
        }

        private void btnDeletedVchrs_Click(object sender, EventArgs e)
        {
            fn.ShowForm<DelVoucherList>();
        }
    }
}
