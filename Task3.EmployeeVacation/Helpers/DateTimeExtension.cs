using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation.Helpers
{
    internal static class DateTimeExtension
    {

        public static IEnumerable<DateTime> RangeTo(this DateTime from, DateTime to, Func<DateTime, DateTime> step = null)
        {
            if (step == null)
            {
                step = x => x.AddDays(1);
            }

            while (from < to)
            {
                yield return from;
                from = step(from);
            }
        }

        public static IEnumerable<DateTime> RangeFrom(this DateTime to, DateTime from, Func<DateTime, DateTime> step = null)
        {
            return from.RangeTo(to, step);
        }
    }
}
