using MsTestApp.Utils;

namespace MsTestApp.UnitTests.Utils
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int x = 10;
            int y = 20;

            // Act
            int sum = Calculator.Add(x, y);

            // Assert
            Assert.AreEqual(30, sum);
        }

        [TestMethod]
        public void Sub_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int x = 30;
            int y = 20;
            int expected = 10;

            // Act
            int actual = Calculator.Sub(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
