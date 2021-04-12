using FindMinAndMaxNumber;
using Xunit;

namespace CalculationMinMaxTest
{
    public class CalculateMinMaxUnitTest
    {
        [Theory]
        [InlineData(new double[] { 1, 7 }, new double[] { 1, 3, 4, 5, 6, 7 })]
        [InlineData(new double[] { -50, 45 }, new double[] { -50, 45, 0, -49, 8 })]
        [InlineData(new double[] { 0, 0 }, new double[] { 0,0,0,0,0 })]
        [InlineData(new double[] { }, new double[] { })]
        [InlineData(new double[] { }, null)]

        public void FindMinMaxTest(double[]expected, double[]inputValues)
        {
            Assert.Equal(expected, CalculationMinMax.CalculateMinAndMax(inputValues));
        }
    }
}
