using System;

namespace OperatorenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 0xF;
            int number3 = 22;
            int number4 = 0b1010;
            string line = new string('*', 40);

            Console.WriteLine(number2);
            Console.WriteLine(line);
            // Increment and Decrement operations
            Console.WriteLine($"{number3}");
            Console.WriteLine($"{number3++}"); //Post increment, value will be changed after output
            Console.WriteLine($"{++number3}"); //Pre increment, value will be changed before output

            Console.WriteLine($"{number1}");
            Console.WriteLine($"{--number1}");
            Console.WriteLine($"{number1--}");

            Console.WriteLine(line);
            // Bool operations
            bool isWinter = true;
            Console.WriteLine($"Do we have winter? {!isWinter}");   //!isWinter flips the value to false

            Console.WriteLine(line);
            Console.WriteLine($"Binary 1010 is: {number4}");

            // Relationale and type operators
            Console.WriteLine(line);
            bool isbigger = number2 > number4;
            Console.WriteLine($"{number2} is bigger as {number4}: {isbigger}");

        }
    }
}
