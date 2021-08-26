using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public static decimal CalculateRectangleArea(decimal length, decimal width)
        {
            return length * width;
        }

        public static decimal CalculateTriangleArea(decimal ground, decimal height)
        {
            return Math.Round((decimal)0.5 * ground * height, 2);
        }
    }
}
