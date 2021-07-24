using System;

namespace Exercise10_NumberSquare
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter smallest number:");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter largest number:");
            int max = Int32.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine();
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j); 
                }

                for (int k = min; k < i; k++)
                {
                    Console.Write(k);
                }
            }
            Console.ReadKey();
        }
    }
}
