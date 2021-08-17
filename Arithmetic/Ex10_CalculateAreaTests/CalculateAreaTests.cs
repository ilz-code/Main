using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ex10_CalculateAreaTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void CalculateCircleArea_ValidRadius_ExpectedArea()
        {
            //Arrange
            double radius = 6.6;

            //Act
            double area = CalculateArea.Geometry.CalculateCircleArea(radius);

            //Assert
            Assert.AreEqual(136.85d, area);
        }

        [TestMethod]
        public void CalculateRectangleArea_LengthAndWidth_ExpectedArea()
        {
            //Arrange
            decimal length = 2.2M;
            decimal width = 3;

            //Act
            decimal area = CalculateArea.Geometry.CalculateRectangleArea(length, width);

            //Assert
            Assert.AreEqual(6.6M, area);
        }

        [TestMethod]
        public void CalculateTriangleArea_GroundAndHeight_ExpectedArea()
        {
            //arrange
            decimal ground = 4.4M;
            decimal height = 3;

            //Act
            decimal area = CalculateArea.Geometry.CalculateTriangleArea(ground, height);

            //Assert
            Assert.AreEqual(6.6M, area);
        }
    }
}
