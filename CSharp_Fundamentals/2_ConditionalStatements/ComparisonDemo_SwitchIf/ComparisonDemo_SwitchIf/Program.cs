// Example demo for conditional statement structures
using System;

namespace ComparisonDemo_SwitchIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional statements with switch-case.
            Console.WriteLine("Enter a char between A and F.");
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
                    Console.WriteLine("No valid char");
                    break;
            }

            // Conditional statements with if-else if - else
            Console.WriteLine("Enter another char between A und F ein.");
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
                Console.WriteLine("No valid char");
            }
        }
    }
}
