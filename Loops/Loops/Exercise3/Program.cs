using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] randomNumbers = new int[20];
            for (int i =0; i < 20; i++)
            {
                randomNumbers[i] = rnd.Next(1000);
            }
            Console.WriteLine(String.Join(" ", randomNumbers));
            Console.WriteLine("Enter one of these numbers:");
            int input = Int32.Parse(Console.ReadLine());
            int index = Array.IndexOf(randomNumbers, input);
            Console.WriteLine($"{input} is in {index +1} position");
            Console.ReadKey();
        }
    }
}
