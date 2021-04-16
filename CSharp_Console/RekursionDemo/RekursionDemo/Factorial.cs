using System;
using System.Collections.Generic;
using System.Text;

namespace RekursionDemo
{
    public static class Factorial
    {
        public static long CalculateFactorialWithRecursion(long input)
        {
            if (input == 1 || input == 0)
            {
                return 1;
            }
            else
            {
                return input * CalculateFactorialWithRecursion(input - 1);
            }
        }

        public static long CalculateFactorialWithIteration(long input)
        {
            if (input == 1 || input == 0)
            {
                return 1;
            }
            else
            {
                long result = input;
                //long steps = input - 1;
                for (long i = 1; i <= input - 1; i++)
                {
                    result = result * (input - i);
                }
                return result;
            }
        }
    }
}
