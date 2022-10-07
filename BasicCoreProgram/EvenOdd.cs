using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            int num;
            Console.WriteLine("please enter number to check even or odd");
            num=Convert.ToInt32(Console.ReadLine());
            if(num %2==0)
                Console.WriteLine( num+" "+ "number is even");
            else
                Console.WriteLine(num+ " " + "number is odd");
        }
    }
}
