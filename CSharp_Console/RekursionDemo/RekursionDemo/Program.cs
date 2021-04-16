using System;
using System.Diagnostics;

namespace RekursionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long inputNumber = 0;
            string consoleInput = "";
            bool isLong = false;
            while (!isLong)
            {
                Console.WriteLine("Enter a positive integer value between 0 and 59");
                consoleInput = Console.ReadLine();
                isLong = long.TryParse(consoleInput, out inputNumber);
                if (inputNumber < 0 || inputNumber > 59)
                {
                    isLong = false;
                }
            }
            Stopwatch watchRecursion = new Stopwatch();
            Stopwatch watchIteration = new Stopwatch();

            watchRecursion.Start();
            long resultRecursion = Factorial.CalculateFactorialWithRecursion(inputNumber);
            watchRecursion.Stop();

            watchIteration.Start();
            long resultIteration = Factorial.CalculateFactorialWithIteration(inputNumber);
            watchIteration.Stop();

            /*
            TimeSpan timeSpan = watchRecursion.Elapsed;
            string timeRecursion = string.Format($"{timeSpan.Seconds:00}.{timeSpan.Milliseconds / 10:00}");
            timeSpan = watchIteration.Elapsed;
            string timeIteration = string.Format($"{timeSpan.Seconds:00}.{timeSpan.Milliseconds / 10:00}");
            */

            Console.WriteLine($"The result for {consoleInput}! with Recursion is {resultRecursion}");
            Console.WriteLine($"Runtime for Recursion: {watchRecursion.ElapsedTicks} Ticks");
            Console.WriteLine($"The result for {consoleInput}! with Iteration is {resultIteration}");
            Console.WriteLine($"Runtime for Recursion: {watchIteration.ElapsedTicks} Ticks");
        }
    }
}
