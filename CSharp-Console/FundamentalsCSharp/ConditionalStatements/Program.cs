// Example demo for conditional statement structures
using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional statements with switch-case.
            Console.WriteLine("Gib einen Buchstaben zwischen A und F ein.");
            string input = Console.ReadLine();
            input = input.ToUpper();
            switch (input)
            {
                case "A":
                case "B":
                    Console.WriteLine("Nice Grade");
                    break;
                case "C":
                case "D":
                    Console.WriteLine("Grade ok.");
                    break;
                case "E":
                case "F":
                    Console.WriteLine("Grade bad");
                    break;
                default:
                    Console.WriteLine("Kein gueltiges Zeichen");
                    break;
            }

            // Conditional statements with if-else if - else
            Console.WriteLine("Gib einen weiteren Buchstaben zwischen A und F ein.");
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A" || input == "B")
            {
                Console.WriteLine("Nice Grade");
            }
            else if (input == "C" || input == "D")
            {
                Console.WriteLine("Grade ok.");
            }
            else if (input == "E" || input == "F")
            {
                Console.WriteLine("Grade bad");
            }
            else
            {
                Console.WriteLine("Kein gueltiges Zeichen");
            }
        }
    }
}