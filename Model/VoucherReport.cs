using System;

namespace Model
{
    public class VoucherReport
    {
        public string vNo { get; set; }
        public DateTime vDate { get; set; }
        public DateTime dueDate { get; set; }
        public string customerName { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }
        public string taskName { get; set; }
        public decimal qty { get; set; }
        public decimal price { get; set; }
        public decimal amount { get; set; }
        public decimal preAmt { get; set; }
        public decimal postAmt { get; set; }
        public decimal vTol { get; set; }
        public decimal disAmt { get; set; }
        public decimal vBal { get; set; }
        public string remark { get; set; }
        public string type { get; set; }
    }
}
