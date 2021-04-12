using System;


namespace EvenOrOdd
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Even or Odd");
            while (true)
            {
                Console.WriteLine("Enter an integer");
                string input = Console.ReadLine();
                bool convertSuccess = int.TryParse(input, out int inputNumber);
                if (!convertSuccess)
                {
                    Console.WriteLine("Wrong input format!");
                }
                else
                {
                    CheckEvenOdd(inputNumber);
                    Console.WriteLine("Please hit the key X to stop");
                    if(Console.ReadKey().KeyChar == (char)120)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        private static void CheckEvenOdd(int inputNumber)
        {
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
