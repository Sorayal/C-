using System;

namespace ImmutableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // This should demonstrate that strings are immutable 
            // The difference in the hash code indicates that we have two different strings here.
            // The strings will be managed in a table.
            string output = "I´m a test string.";
            Console.WriteLine(output.GetHashCode().ToString());
            output = "I´m another test string.";
            Console.WriteLine(output.GetHashCode().ToString());
            Console.WriteLine(new string('+',40));

            // Before a new string object will be created, the runtime environment looks
            // if there is a match for the string text. If yes, it will be referenced.
            // So secondOutput references to firstOutput now.
            string firstOutput = "I´m a test string.";
            Console.WriteLine(firstOutput.GetHashCode().ToString());
            string secondOutput = "I´m a test string.";
            Console.WriteLine(secondOutput.GetHashCode().ToString());
        }
    }
}
