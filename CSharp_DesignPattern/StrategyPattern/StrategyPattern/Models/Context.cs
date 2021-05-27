using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class Context
    {
        private IOperation _operation;

        public Context(IOperation operation)
        {
            _operation = operation;
        }

        public int ExecuteOperation(int firstNumber, int secondNumber)
        {
            return _operation.Calculate(firstNumber, secondNumber);
        }
    }
}
