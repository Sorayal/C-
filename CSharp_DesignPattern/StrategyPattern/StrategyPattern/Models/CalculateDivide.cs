using StrategyPattern.Interface;
using System;

namespace StrategyPattern.Models
{
    public class CalculateDivide : IOperation
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            if(secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            throw new ArgumentException("second number is 0", nameof(secondNumber));
        }
    }
}
