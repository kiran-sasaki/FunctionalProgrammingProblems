using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class LeapYear
    {
        public static void LeapYearCheck()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4) == 0 && (year % 100) != 0 || (year % 400) == 0)
            {
                Console.WriteLine(year + " it is leap year");
            }
            else
            {
                Console.WriteLine(year + " it is not a leap year");
            }
        }
    }
}
