using FigureArea.Figures;
using FigureArea.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureArea.Tests
{
    [TestClass]
    public class TriangleAreaTests
    {
        [TestMethod]
        public void GetArea_10and10and10_43returned()
        {
            // Arrange
            var firstSide = 10;
            var secondSide = 10;
            var thirdSide = 10;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var triangleArea = new TriangleArea();
            var expected = 43.30;

            // Act
            var actual = triangleArea.GetArea(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetArea_5and3and4_6returned()
        {
            // Arrange
            var firstSide = 5;
            var secondSide = 3;
            var thirdSide = 4;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var triangleArea = new TriangleArea();
            var expected = 6;

            // Act
            var actual = triangleArea.GetArea(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
