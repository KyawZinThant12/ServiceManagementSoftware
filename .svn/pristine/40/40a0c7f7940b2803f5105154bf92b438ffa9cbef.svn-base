using System;

namespace Model
{
    public class TaskItem
    {
        public long taskItemId { get; set; }
        public long vId { get; set; }
        public int taskId { get; set; }
        public decimal qty { get; set; }
        public decimal cost { get; set; }
        public decimal disPer { get; set; }
        public decimal disAmt { get; set; }
        public decimal amount { get; set; }
        public TStatus status { get; set; }
        public DateTime createAt { get; set; }
        public DateTime? finishAt { get; set; }
        public int? empId { get; set; }
        public Priority priority { get; set; }

        public Task task { get; set; }
        public Employee employee { get; set; }
    }

    public enum TStatus
    {
        Pending,
        Finish
    }

    public enum Priority
    {
        Normal,
        High,
        Urgent
    }

    public class TaskItemDetail : TaskItem
    {
        public string asignee { get; set; }
        public string customerName { get; set; }
        public string taskName { get; set; }
        public DateTime dueDate { get; set; }
    }

    public class TaskItemCount
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public int count { get; set; }
        public decimal tolAmt { get; set; }
    }

    public class TaskItemTolAmt
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public int count { get; set; }
        public decimal tolAmt { get; set; }
        public string vNo { get; set; }
        public DateTime vDate { get; set; }
        public string customerName { get; set; }
    }
}
