using System;

namespace Model
{
    public class Period
    {
        public string periodName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        int _periodId;
        public int periodId
        {
            get
            {
                return _periodId;
            }
            set
            {
                _periodId = value;
                switch (_periodId)
                {
                    case 0:
                        periodName = "Today";
                        startDate = DateTime.Today;
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;
                    case 1:
                        periodName = "One Week";
                        startDate = DateTime.Today.AddDays(-7);
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;
                    case 2:
                        periodName = "One Month";
                        startDate = DateTime.Today.AddMonths(-1);
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;
                    case 3:
                        periodName = "One Year";
                        startDate = DateTime.Today.AddYears(-1);
                        endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;
                    default:
                        periodName = "Custom";
                        if (startDate == DateTime.MinValue)
                            startDate = DateTime.Today;
                        if (endDate == DateTime.MinValue)
                            endDate = DateTime.Today.AddDays(1).AddTicks(-1);
                        break;
                }
            }
        }
    }

    public class PeriodCusStatus : Period
    {
        public int? customerId { get; set; }
        public VStatus? status { get; set; }
    }

    public class PeriodUser : Period
    {
        public string userId { get; set; }
    }
}
