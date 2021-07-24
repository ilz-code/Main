using System;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int maxNum = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNum; i++)
            {
                if ((i-1) % 20 == 0)
                    Console.WriteLine();
                if (i % 15 == 0)
                    Console.Write(" FizzBuzz");
                else if (i % 3 == 0)
                    Console.Write(" Fizz");
                else if (i % 5 == 0)
                    Console.Write(" Buzz");
                else
                    Console.Write(" " + i);
            }
            Console.ReadKey();
        }
    }
}
