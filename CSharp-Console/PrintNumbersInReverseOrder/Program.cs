using System;


// This programme reads n inputs of integers and returns the result in reversed order

namespace PrintNumbersInReverseOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {         
            int nInput = 0;
            bool isPositiveNumber = false;

            while (!isPositiveNumber)
            {
                Console.WriteLine("Please enter how many integer numbers should be read: ");
                string input = Console.ReadLine();
                isPositiveNumber = CheckForInt(input, ref nInput);
                if(nInput < 0)
                {
                    Console.WriteLine("Negative input!");
                    isPositiveNumber = false;
                }
            }

            bool isNumber;
            int[] bunchOfIntegers = new int[nInput];
            for (int i = 0; i < bunchOfIntegers.Length; i++)
            {
                isNumber = false;
                while (!isNumber)
                {
                    Console.WriteLine($"Enter the {i + 1}. Number");
                    string input = Console.ReadLine();
                    isNumber = CheckForInt(input, ref nInput);
                }
                bunchOfIntegers[i] = nInput;
            }

            ReverseIntArray(bunchOfIntegers);
            foreach (var number in bunchOfIntegers)
            {
                Console.Write($" {number} ");
            }
        }

        #region CheckForInt
        public static bool CheckForInt(string input, ref int nInput)
        {
            bool ConvertSuccess = int.TryParse(input, out nInput);
            if (!ConvertSuccess)
            {
                Console.WriteLine("Invalid input!");
            }
            return ConvertSuccess;
        }
        #endregion

        #region ReverseIntArray
        public static void ReverseIntArray(int[] bunchOfIntegers)
        {
            int swap;
            int lastPosition = bunchOfIntegers.Length - 1;
            for (int i = 0; i < bunchOfIntegers.Length/2; i++)
            {
                swap = bunchOfIntegers[lastPosition - i];
                bunchOfIntegers[lastPosition - i] = bunchOfIntegers[i];
                bunchOfIntegers[i] = swap;
            }
        }
        #endregion
    }
}
