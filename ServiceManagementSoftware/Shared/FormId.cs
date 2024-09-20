namespace ServiceManagementSoftware.Shared
{
    public class FormId
    {
        public const string Home = "fm_Home_Menu";
        //public const string Report = "Report_Menu";
        public const string TaskHis = "fm_TaskList_Menu";
        //public const string Setup = "Setup_Menu";
        public const string Option = "fm_Option_Menu";

        // report
        public const string VCashRec = "rp_VoucherCashReceived";
        public const string PopTask = "rp_PopularTasks";
        public const string CashByTask = "rp_CashReceivedByTask";
        public const string Voucher = "rp_Vouchers";
        public const string ActionLog = "rp_ActionLog";
        public const string PNL = "rp_Profit&Loss";
        public const string DailySum = "rp_DailySummary";
        public const string DelVchrs = "rp_DeletedVouchers";

        // setup
        public const string Customer = "fm_Customer_Setup";
        public const string Employee = "fm_Employee_Setup";
        public const string Task = "fm_Task_Setup";
        public const string Item = "fm_Item_Setup";
        public const string AppUser = "fm_AppUser_Setup";

        // voucher
        public const string VoucherEntry = "VoucherEntry"; // for action log
        public const string VouLockUnLock = "al_VoucherLockUnlock";
        public const string VouDel = "al_VoucherDelete";
    }
}
