using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class ComputeQuotient
    {
        public static void calcualte()
        {
            int dividend ,divisor;
            Console.WriteLine("enter the dividend");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend/divisor;
            int remainder= dividend%divisor;
            Console.WriteLine("dividend: {0} divisor {1}",dividend,divisor);
            Console.WriteLine("quotient = {0}",quotient);
            Console.WriteLine("remainder = {0}",remainder);
        }
    }
}
