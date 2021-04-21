// Example demo for conditional statement structures
// switch-case vs if-else
using System;

namespace AnotherSwitchDemoWithCombinedCases
{
    public class Program
    {
        public static void Main()
        {
            // Conditional statements with switch-case.
            Console.WriteLine("Enter a char between A und F: ");
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
                    Console.WriteLine("Not a valid char");
                    break;
            }

            // Conditional statements with if-else if - else
            Console.WriteLine("Enter another char between A und F: ");
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
                Console.WriteLine("Not a valid char");
            }
        }
    }
}
