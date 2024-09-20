using System;
using System.Collections.Generic;

namespace Model
{
    public class Voucher
    {
        public long vId { get; set; }
        public string vNo { get; set; }
        public DateTime vDate { get; set; }
        public int? customerId { get; set; }
        public DateTime dueDate { get; set; }
        public int? empId { get; set; }
        public decimal preAmt { get; set; }
        public decimal postAmt { get; set; }
        public DateTime preDate { get; set; }
        public DateTime postDate { get; set; }
        public decimal vTol { get; set; }
        public decimal disPer { get; set; }
        public decimal disAmt { get; set; }
        public decimal vBal { get; set; }
        public string remark { get; set; }
        public VStatus status { get; set; }
        public bool locked { get; set; }
        public bool deleted { get; set; }

        public Customer customer { get; set; }
        public Employee employee { get; set; }
        public IEnumerable<TaskItem> taskItems { get; set; }
        public IEnumerable<VoucherCharge> voucherCharges { get; set; }
    }

    public enum VStatus
    {
        Pending,
        Finish,
        Paid
    };

    public class VoucherAmount : Voucher
    {
        public string customerName { get; set; }
        public decimal netAmt { get { return vTol - disAmt; } }
        public decimal recAmt { get { return preAmt + postAmt; } }
    }
}
