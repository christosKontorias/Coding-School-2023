using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ProgramFive
    {
        int numberinSeconds = 45678;

        public int MinutesCalculation()
        {
            int secToMinutes = numberinSeconds / 60;
            Console.WriteLine("In Seconds: 45678.");
            return secToMinutes;
        }
        
        public int HoursCalculation()
        {
            int secToHours = numberinSeconds / 3600;
            return secToHours;
        }
        public int DaysCalculation()
        {
            int secToDays = numberinSeconds / (24 * 3600);
            return secToDays;
        }
        public int YearsCalculation()
        {
            int secToYears = numberinSeconds / 3153600;
            return secToYears;
        }
        
    }
}
