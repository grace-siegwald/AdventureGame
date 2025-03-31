using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
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
        public static string GetArrayOfTextFromExternalFile(string path)
        {
            string[] output;
            if (File.Exists(path))
            {
                // everything is great!
                output = File.ReadAllLines(path);
            }

            // if it's null, we know it didn't find any info. If it's not null, we know it worked!
            return null;
        }
        public static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void TryAgain()
        {
            Console.WriteLine("Press any key to try again");
            Console.ReadKey();
        }

        public static void PrintWithColor(string wholeSentence, string colorWord, string color) 
        {
            string[] sentence = wholeSentence.Split(" ");
            foreach (string word in sentence)
            {
                if (word == colorWord & color == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkBlue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkGreen")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkCyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkRed")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkMagenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkYellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "DarkGray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                if (word == colorWord & color == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(word);
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    DefaultConsoleColor();
                    Console.Write(word + " ");
                }
            }
        }

        public static void DefaultConsoleColor()
        {
            Console.BackgroundColor = System.ConsoleColor.DarkGray;
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        
        // This method was written by ChatGPT
        public static void ClearLine(int line)
        {
            int currentLine = Console.CursorTop; // Store current cursor position
            Console.SetCursorPosition(0, line);
            Console.Write(new string(' ', Console.WindowWidth)); // Overwrite with spaces
            Console.SetCursorPosition(0, currentLine); // Restore cursor position
        }
    }
}
