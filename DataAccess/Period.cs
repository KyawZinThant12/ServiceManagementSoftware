using m = Model;

namespace DataAccess
{
    public class Period
    {
        public static m.Period[] Get()
        {
            return new m.Period[]
                {
                    new m.Period { periodId = 0 },
                    new m.Period { periodId = 1 },
                    new m.Period { periodId = 2 },
                    new m.Period { periodId = 3 },
                    new m.Period { periodId = 4 },
                };
        }
    }
}
