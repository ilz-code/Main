using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ex10_CalculateAreaTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void CalculateCircleArea_radius_area()
        {
            double radius = 6.6;
            double area = CalculateArea.Geometry.CalculateCircleArea(radius);
            Assert.AreEqual(136.85d, area);
        }

        [TestMethod]
        public void CalculateRectangleArea_lengthAndWidth_area()
        {
            decimal length = 2.2M;
            decimal width = 3;
            decimal area = CalculateArea.Geometry.CalculateRectangleArea(length, width);
            Assert.AreEqual(6.6M, area);
        }

        [TestMethod]
        public void CalculateTriangleArea_groundAndHeight_area()
        {
            decimal ground = 4.4M;
            decimal height = 3;
            decimal area = CalculateArea.Geometry.CalculateTriangleArea(ground, height);
            Assert.AreEqual(6.6M, area);
        }
    }
}
