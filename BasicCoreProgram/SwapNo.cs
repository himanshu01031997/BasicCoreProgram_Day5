using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class SwapNo
    {
        public static void SwappingTwoNo()
        {
            int a, b;
            Console.WriteLine("before swapping ");
            Console.WriteLine("please enter first no :");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second no:");
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swapping numbers are :\n a is {0} \n b is {1}",a,b);

        }
    }
}
