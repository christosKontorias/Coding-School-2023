using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ProgramSix
    {
        public double MinutesTimeSpan()
        {
            var timeSpan = new TimeSpan(0, 0, 45678);
            return timeSpan.TotalMinutes;
        }
        public double HoursTimeSpan()
        {
            var timeSpan = new TimeSpan(0, 0, 45678);
            return timeSpan.TotalHours;
        }
        public double DaysTimeSpan()
        {
            var timeSpan = new TimeSpan(0, 0, 45678);
            return timeSpan.TotalDays;
        }
        public double YearsTimeSpan()
        {
            var timeSpan = new TimeSpan(0, 0, 45678);
            double yearsTimeSpan = timeSpan.TotalDays / 365;
            return yearsTimeSpan;
        }
    }
}
