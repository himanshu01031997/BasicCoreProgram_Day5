namespace BasicCoreProgram
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to Basic Core Program!");
           
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1.FlipCoin\n2.leapyear\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin.CalculatePercent();
                        break;
                    case 2:
                        LeapYear.CheckYear();
                       break;
                    default:
                        break;
                }
            }
    }
}