using System;

namespace WhileDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int zaehler = 0;
            bool breakLoop = false;
            Console.WriteLine("While loop");
            while(!breakLoop)
            {
                Console.WriteLine("Machen Sie bitte ihre Eingabe.");
                Console.WriteLine("Druecke Escape zum Beenden oder beliebige Taste zum Fortsetzen.");
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    breakLoop = true;
                }
                else
                {
                    zaehler += 1;
                    Console.WriteLine($"In While loop seit {zaehler} Runden!");
                }
            }

            Console.WriteLine("\n\n");
            breakLoop = false;
            zaehler = 0;
            Console.WriteLine("Do-While loop");
            do
            {
                Console.WriteLine("Machen Sie bitte ihre Eingabe.");
                Console.WriteLine("Druecke Escape zum Beenden oder beliebige Taste zum Fortsetzen.");
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    breakLoop = true;
                }
                else
                {
                    zaehler += 1;
                    Console.WriteLine($"In Do-While loop seit {zaehler} Runden!");
                }
            } while (!breakLoop);      
        }
    }
}
