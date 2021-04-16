using RekursionDemo;
using System;
using Xunit;

namespace RecursionDemoTests
{
    public class CalculateTest
    {
        [Theory]
        [InlineData(4,24)]
        [InlineData(8, 40320)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(11, 39916800)]
        public void TestCalculateFactorialWithRecursion(long input, long result)
        {
            Assert.Equal(Factorial.CalculateFactorialWithRecursion(input), result);
        }

        [Theory]
        [InlineData(4, 24)]
        [InlineData(8, 40320)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(11, 39916800)]
        public void TestCalculateFactorialWithIteration(long input, long result)
        {
            Assert.Equal(Factorial.CalculateFactorialWithIteration(input), result);
        }
    }
}
