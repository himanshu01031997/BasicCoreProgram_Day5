using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class LargestNo
    {
        public static void FindLargest()
        {
            int  num1, num2, num3;
            Console.WriteLine("find the largest of three numbers");
            Console.WriteLine("input the 1st number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("First number is largest among all");
                }
                else
                {
                    Console.WriteLine("Third number is largest among all");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("the Second numbers is largest among all");
            }
            else
            {
                Console.WriteLine("the Third number is greatest among all");
            }


        }
    }
}
