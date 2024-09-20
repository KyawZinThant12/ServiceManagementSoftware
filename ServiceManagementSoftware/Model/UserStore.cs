namespace ServiceManagementSoftware.Model
{
    public class UserStore
    {
        public StoreId storeId { get; set; }
        public object value { get; set; }
    }

    public enum StoreId
    {
        HomeView,
        VhCaRe_Period,
        CaReByTk_Period,
        PopularTask_Period,
        VList_Period,
        AList_Period,
        Cash_Period,
        PnL_Period,
        DS_Period,
        DelV_Period
    };
}
