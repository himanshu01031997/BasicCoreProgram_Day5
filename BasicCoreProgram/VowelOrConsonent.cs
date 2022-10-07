using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class VowelOrConsonent
    {
        public static void CheckAlphabate()
        {
            char c;
            Console.WriteLine("enter the character");
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("character is vowel");

            }
            else if(c >= 'a' && c <= 'z' || c >= 'A'&& c<= 'Z')
            {
                Console.WriteLine("character is not vowel");
            }
            else
            {
                Console.WriteLine("not a valid character");
            }
        }
    }
}
