using FigureArea.Figures;
using FigureArea.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureArea.Tests
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void GetArea_10radius_314returned()
        {
            // Arrange
            var radius = 10;
            var circle = new Circle(radius);
            var circleArea = new CircleArea();
            var expected = 314;

            // Act
            var actual = circleArea.GetArea(circle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetArea_22radius_1519returned()
        {
            // Arrange
            var radius = 22;
            var circle = new Circle(radius);
            var circleArea = new CircleArea();
            var expected = 1519.76;

            // Act
            var actual = circleArea.GetArea(circle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
