using System;

namespace Ex1_IsFifteen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fifteen.IsFifteen(a, b));
            Console.ReadKey();
        }
    }
}
