using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern");
            // Setting reference to a new instance of Context and gives the class reference 
            // for choosing the right method.
            Context context = new Context(new CalculateAdd());
            Console.WriteLine($"20 + 5 = { context.ExecuteOperation(20,5)}");

            context = new Context(new CalculateSubtract());
            Console.WriteLine($"20 - 5 = { context.ExecuteOperation(20, 5)}");

            context = new Context(new CalculateMultiply());
            Console.WriteLine($"20 * 5 = { context.ExecuteOperation(20, 5)}");

            context = new Context(new CalculateDivide());
            Console.WriteLine($"20 / 5 = { context.ExecuteOperation(20, 5)}");
        }
    }
}
