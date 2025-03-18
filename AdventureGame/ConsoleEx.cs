using System;
namespace AdventureGame
{
    public class ConsoleEx
    {
        public void Write(ConsoleColor color, string format, params object[] arg)
        {
            var current = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(format, arg);
            Console.ForegroundColor = current;
        }

        public void WriteLine(ConsoleColor color, string format, params object[] arg) =>
            Write(color, $"{format}\n", arg);

        public static void WriteBold(string format, params object[] arg) =>
            Console.Write($"\x1b[1m{format}\x1b[0m", arg);

        public void WriteBoldLine(string format, params object[] arg) =>
           WriteBold($"{format}\n", arg);
    }
}