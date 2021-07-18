using System;

namespace Ex4_Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int product = 1;
            for (int i = 1; i <= number; i++)
                product *= i;
            Console.WriteLine($"The Product from 1 to {number} is {product}");
            Console.ReadKey();

        }
    }
}
