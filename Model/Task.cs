using System.Collections.Generic;

namespace Model
{
    public class Task
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public decimal cost { get; set; }
        public string remark { get; set; }
        public bool inActive { get; set; }

        public IEnumerable<TaskCharge> taskCharges { get; set; }
    }
}
