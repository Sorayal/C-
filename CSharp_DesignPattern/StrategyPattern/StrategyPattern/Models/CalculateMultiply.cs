using StrategyPattern.Interface;

namespace StrategyPattern.Models
{
    public class CalculateMultiply : IOperation
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
