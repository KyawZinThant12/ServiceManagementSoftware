namespace Model
{
    public class DailySummary
    {
        public DSService[] services { get; set; }

        public decimal tolAmount { get; set; }
        public decimal disAmt { get; set; }
        public decimal netAmount { get { return tolAmount - disAmt; } }
        public decimal preAmt { get; set; }
        public decimal postAmt { get; set; }
    }

    public class DSService
    {
        public string name { get; set; }
        public decimal qty { get; set; }
        public decimal price { get; set; }
        public decimal amount { get; set; }
        public string type { get; set; } // service OR stock
    }
}
