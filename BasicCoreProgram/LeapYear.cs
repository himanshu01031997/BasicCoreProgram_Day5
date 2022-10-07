using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class LeapYear
    {
        public static void CheckYear()
        {
            Console.WriteLine("please enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("year is leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("year is  leap year");
            }
            else
            {
                Console.WriteLine("year is not leap year");
            }
        }
    }
}
