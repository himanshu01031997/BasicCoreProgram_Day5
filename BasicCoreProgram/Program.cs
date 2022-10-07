namespace BasicCoreProgram
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to Basic Core Program!");
           
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1.FlipCoin\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin.CalculatePercent();
                        break;
                 
                    default:
                        break;
                }
            }
    }
}