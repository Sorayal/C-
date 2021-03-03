using System;

namespace UnitTestingExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unit Test Example");
            Console.WriteLine("Enter 2 Integer numbers");
            Console.WriteLine("First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = MathMethod.Add(firstNumber, secondNumber);
            Console.WriteLine($"Das Ergebnis lautet: {result}");
        }
    }

    public static class MathMethod
    {
        public static int Add(int firstNumber, int secondNumber) => firstNumber + secondNumber;
    }
}
