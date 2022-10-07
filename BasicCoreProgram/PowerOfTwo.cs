using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class PowerOfTwo
    {
        public const int num = 2;

        public static void CheckPower()
        {
            int p;
            Console.WriteLine("check the  power of two");
            Console.WriteLine("enter power");
            p = Convert.ToInt32(Console.ReadLine());
            for (int power = 0; power <= 31; power++)
            {
                Console.WriteLine("{0}^{1} = {2:N0} ", num, p, (double)Math.Pow(num, p));
                Console.ReadLine();
            }
        }
    }

}   
            
        
