using BMI_Weight_Calculator.Interfaces;
using System;

namespace BMI_Weight_Calculator.Implementations
{
    public sealed class CustomException : Exception, ICustomException
    {
        private static CustomException exceptionObject = null;

        private CustomException() { }

        public static CustomException GetExceptionObject
        {
            get
            {
                if(exceptionObject == null)
                {
                    exceptionObject = new CustomException();
                }
                return exceptionObject;
            }
        }

        public void ThrowWeightException()
        {
            Console.WriteLine("input invalid. Must be in range between 0 and 500. Try again.");
        }

        public void ThrowHeightException()
        {
            Console.WriteLine("input invalid. Must be in range between 0.01 and 2.50. Try again.");
        }

    }
}
