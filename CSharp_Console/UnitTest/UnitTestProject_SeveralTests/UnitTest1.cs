using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExamples;

// Unit Tests follow the AAA-pattern. 
// 1. Arrange the parameters for the method and what you expect from the tested method
// 2. Act on the method, you want to test
// 3. Assert and see if the actual result matches the result you expected from the method.



namespace UnitTestProject_SeveralTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Time Out in Milliseconds
        [Timeout(800)]
        public void TestMethod_Add()
        {
            //Arrange
            int value1 = 15;
            int value2 = 24;
            int expectedResult = 39;

            // Arrange several values for a test
            int[] testValues = { 2, 4, 5, 6, 9, 23, 56, 78 };
            int[] expectedSum = { 6, 9, 11, 15, 32, 79, 134 };

            //Act
            int actualResult = MathMethod.Add(value1,value2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

            //Assert for an array
            for (int i = 0; i < testValues.Length-1; i++)
            {
                actualResult = MathMethod.Add(testValues[i],testValues[i+1]);
                expectedResult = expectedSum[i];
                Assert.AreEqual(actualResult, expectedResult);
            }
        }
    }
}
