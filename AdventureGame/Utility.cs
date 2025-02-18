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

        public static int GetRandomNumber(int max)
        {
            return RandomNumberGenerator.Next(max);
        }

        public static int GetRandomNumber(int min, int max)
        {
            return RandomNumberGenerator.Next(min, max);
        }

        // Here, the arrow => acts as the "return" in the above example
        //public static int GetRandomNumber(int max) => RandomNumberGenerator.Next(max);
        //public static int GetRandomNumber(int min, int max) => RandomNumberGenerator.Next(min, max);

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
