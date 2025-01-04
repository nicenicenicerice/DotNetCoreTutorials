using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.UnitTests.Utils
{
    [TestClass]
    public class PainterTests
    {
        [TestMethod]
        public void DrawPoint_ValidCoordinatesAndPositiveSize_ReturnsPointWithSpecifiedParameters()
        {
            // Arrange
            int x = 10;
            int y = 20;
            int size = 30;
            Point expected = new Point(x, y, size);
            Painter target = new Painter();

            // Act
            Point actual = target.DrawPoint(x, y, size);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}