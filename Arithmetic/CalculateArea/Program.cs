using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; 
            do
            {                
                choice = GetMenu();

                if (choice == 1)
                {
                    Console.WriteLine("What is the circle's radius? ");
                    var keyboard = Console.ReadLine();
                    double.TryParse(keyboard, out var radius);
                    Console.WriteLine("The circle's area is " + Geometry.CalculateCircleArea(radius));
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter length? ");
                    decimal length = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter width? ");
                    decimal width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("The rectangle's area is " + Geometry.CalculateRectangleArea(length, width));
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter length of the triangle's base? ");
                    decimal ground = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter triangle's height? ");
                    decimal height = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("The triangle's area is " + Geometry.CalculateTriangleArea(ground, height));
                }
                else 
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {
            int userChoice;            
            
            Console.WriteLine("\nGeometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

            userChoice = Convert.ToInt32(Console.ReadLine());
            
            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\nPlease enter a valid range: 1, 2, 3, or 4: ");                
                userChoice = Convert.ToInt32(Console.ReadLine()); 
            }
            return userChoice;
        }       
    }
}
