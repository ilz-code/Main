using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Geometry
    {
        public static void calculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var radius);
            Console.WriteLine("The circle's area is "
                + Math.Round(Math.PI * Math.Pow(radius, 2), 2));
        }

        public static void calculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The rectangle's area is " + length * width);
        }

        public static void calculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal ground = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The triangle's area is " + Math.Round((decimal)0.5 * ground * height, 2));
        }
    }
}
