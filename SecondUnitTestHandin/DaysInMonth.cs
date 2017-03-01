using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondUnitTestHandin
{
    public class DaysInMonth
    {
        public int getNumDaysinMonth(int month, int year)
        {
            try
            {
                int days = 0;

                if (month < 1 || month > 12) throw new ArgumentOutOfRangeException("Month has to be between 1 and 12");
                if (year < 0 || year > int.MaxValue - 1) throw new ArgumentOutOfRangeException("Year has to be a int sized number");

                if (month == 2 && isLeapAYear(year)) days = 29;
                if (month == 2 && !isLeapAYear(year)) days = 28;
                if (month != 2) days = daysInMonth(month);

                return days;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        // check for leap year
        private bool isLeapAYear(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 4 == 0 & year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            else return false;
        }


        // check for days in month
        private int daysInMonth(int m)
        {
            
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                
                return 31;
            }
            else
            {
                return 30;
            }
        }
    }
}
