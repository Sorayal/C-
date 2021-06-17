using System;

namespace ChallengeJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 rows , 2 columns
            string[][]friends = new string[][]
            {
                new string[] {"Tom", "Peter"},
                new string[] {"Ahmed", "Dennis"},
                new string[] {"Sascha", "Julia"}
            };

            Console.WriteLine($"Hallo {friends[1][0]}, ich bin {friends[0][0]}");
            Console.WriteLine($"Hallo {friends[1][1]}, ich bin {friends[0][1]}");
            Console.WriteLine($"Hallo {friends[2][0]}, ich bin {friends[0][0]}");
            Console.WriteLine($"Hallo {friends[2][1]}, ich bin {friends[0][1]}");
        }
    }
}
