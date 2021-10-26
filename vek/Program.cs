using System;

namespace vek
{
    class Program
    {
        static void Main(string[] args)
        {

            double age;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(15, 10);
            Console.Write("╔═════════════════╗");

            Console.SetCursorPosition(15, 11);
            Console.WriteLine("║napište svůj věk ║");

            Console.SetCursorPosition(15, 12);
            Console.Write("╚═════════════════╝");

            Console.SetCursorPosition(15, 15);
            Console.ReadLine();


           

        }
    }
}
