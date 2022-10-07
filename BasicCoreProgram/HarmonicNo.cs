using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class HarmonicNo
    {
        public static void CalculateHarmonic()
        {
            int num, count;
            double sum = 0;
            Console.WriteLine("calculate the sum of harmonic no");
            Console.WriteLine("------------------------------");
            Console.WriteLine("enter the value of Number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (count = 1; count <= num; count++)
            {
                Console.WriteLine("1/{0}", count);
                sum = sum + 1 / (float)count;// it will shows decimal values
            }
            Console.WriteLine("sum of series of {0} terms: {1}", num, sum);
        }
    }
}
