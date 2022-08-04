using System;

namespace Curso
{
    public class Printer
    {
        public static void ColorWriteLine(string text, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ColorWriteLine(string text, ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.WriteLine(text);
            Console.ResetColor();
        }


        public static void ColorWrite(string text, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.Write(text);
            Console.ResetColor();
        }


        public static void ColorWrite(string text, ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(text);
            Console.ResetColor();
        }

    }
}
