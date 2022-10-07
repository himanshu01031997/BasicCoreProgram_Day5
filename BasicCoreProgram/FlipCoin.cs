using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class FlipCoin
    {
        public static void CalculatePercent()
        {

            int headcount = 0;
            int tailcount = 0;
            double headpercentage;
            double tailpercentage;
            Console.WriteLine("enter the number of time flip");
            int flipcoin = Convert.ToInt32(Console.ReadLine());
            if (flipcoin > 0)
            {
                for (int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("random number generated :{0}", number);
                    if (number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                Console.WriteLine("the count of head is {0}", headcount);
                Console.WriteLine("the count of tail is {0}", tailcount);

                headpercentage = headcount * 100 / flipcoin;
                tailpercentage = tailcount * 100 / flipcoin;

                Console.WriteLine("the percentage of head is  {0}", headpercentage);
                Console.WriteLine("the percentage of tail is {0}", tailpercentage);

            }
        }
    }
}
