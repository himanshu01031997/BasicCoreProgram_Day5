﻿namespace BasicCoreProgram
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to Basic Core Program!");
           
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1.FlipCoin\n2.Leapyear\n3.HarmonicNo\n4.EvenOrOdd\n5.CheckAlphabate\n6.SwapNo\n7.LargestNo\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin.CalculatePercent();
                        break;
                    case 2:
                        LeapYear.CheckYear();
                       break;
                    case 3:
                        HarmonicNo.CalculateHarmonic();
                       break;
                    case 4:
                       EvenOdd.CheckEvenOdd();
                       break;
                    case 5:
                       VowelOrConsonent.CheckAlphabate();
                       break;
                    case 6:
                       SwapNo.SwappingTwoNo();
                       break;
                    case 7:
                    LargestNo.FindLargest();
                    break;
                    default:
                       break;
                }
            }
    }
}