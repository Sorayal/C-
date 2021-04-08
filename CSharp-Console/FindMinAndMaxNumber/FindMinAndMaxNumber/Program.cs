using System;

namespace FindMinAndMaxNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Min Max Calculation");
            double[] randomArray1 = { 1,3,55.6,588,-5,11134.6};
            double[] randomArray2 = { 1, 0, 5.6, 58, 66,-5, 1 ,858,-5,0,4,-588};
           
            try 
            {
                double[] result = CalculationMinMax.CalculateMinAndMax(randomArray1);
                PrintingMinMaxResult(result);

                result = CalculationMinMax.CalculateMinAndMax(randomArray2);
                PrintingMinMaxResult(result);

                result = CalculationMinMax.CalculateMinAndMax(null);
                PrintingMinMaxResult(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void PrintingMinMaxResult(double[] result)
        {
            if (result.Length == 2) 
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine($"Minimum: {result[0]}");
                Console.WriteLine($"Maximum: {result[1]}");
            }
        }
    }
}
