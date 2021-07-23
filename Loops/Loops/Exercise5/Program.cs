using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string secondWord = Console.ReadLine();

            Console.Write(firstWord);
            int dots = 30 - firstWord.Length - secondWord.Length;
            for (int i = 0; i < dots; i++)
            {
                Console.Write(".");
            }
            Console.Write(secondWord);
            Console.ReadKey();
        }
    }
}
