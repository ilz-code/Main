using System;

namespace Exercise8_AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                int num1 = 8 * i;
                int num2 = (8 * (number - 1) - num1) / 2;
                
                for (int j = 0; j < num2; j++)
                {                    
                    Console.Write("/");
                }

                for (int k = 0; k < num1; k++)
                {                   
                    Console.Write("*");
                }

                for (int m = 0; m < num2; m++)
                {
                    Console.Write("\\");
                }
            }
            Console.ReadKey();
        }
    }
}
