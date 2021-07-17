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
                choice = getMenu();

                if (choice == 1)
                {
                    Geometry.calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Geometry.calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Geometry.calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
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
