using System.Linq;
namespace FindMinAndMaxNumber
{
    
    public static class CalculationMinMax
    {
        // Old Method without using Linq
        /*
        public static double[] CalculateMinAndMax(double[] dataArray)
        {
            double[] result = { 0, 0 };
            if (dataArray is object && dataArray.Length != 0)
            {
                double minValue = dataArray[0];
                double maxValue = dataArray[0];
                for (int i = 0; i < dataArray.Length; i++)
                {
                    if (dataArray[i] < minValue) { minValue = dataArray[i]; }
                    if (dataArray[i] > maxValue) { maxValue = dataArray[i]; }
                }
                result[0] = minValue;
                result[1] = maxValue;
            }
            return result;
        }
        */

        // Refactored Method using Linq.
        public static double[] CalculateMinAndMax(double[] dataArray)
        {
            double [] result = new double[] { };
            if (dataArray is object && dataArray.Length != 0 )
            {
                result = new double[] { dataArray.Min(), dataArray.Max() };
            }
            return result;
        }

        // Another variant with two return paths
        /*
        public static double[] CalculateMinAndMax(double[] dataArray)
        {
            if (dataArray is object && dataArray.Length != 0)
            {
                return new double[] { dataArray.Min(), dataArray.Max() };
            }
            else
            {
                return new double[] { };
            }
        }
        */
    }
}
