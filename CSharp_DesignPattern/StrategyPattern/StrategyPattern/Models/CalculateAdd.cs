using StrategyPattern.Interface;

namespace StrategyPattern.Models
{
    public class CalculateAdd : IOperation
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
