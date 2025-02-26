using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Utility
    {
        public static Random RandomNumberGenerator = new Random();

        // These are Overloaded Methods - More than one method with the same name, each with different "signitures".
        public static int GetRandomNumber(int max)
        {
            return RandomNumberGenerator.Next(max);
        }
        public static int GetRandomNumber(int min, int max)
        {
            return RandomNumberGenerator.Next(min, max);
        }

        // Here, the arrow => acts as the "return" 
        //public static int GetRandomNumber(int max) => RandomNumberGenerator.Next(max);
        //public static int GetRandomNumber(int min, int max) => RandomNumberGenerator.Next(min, max);

        
        // These methods need to be "static" so we don't need to make a new instance of "Utility" every time we use these methods.
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Continue()
        {
            Print($"Press any key to continue");
            Console.ReadKey();
        }

        public static int ConvertStringToInteger(string input)
        {
            if (int.TryParse(input, out int result)) return result;
            return -1;
        }
    }
}
