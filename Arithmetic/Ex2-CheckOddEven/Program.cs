using System;

namespace Ex2_CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(OddEven.IsOddOrEven(number));
            Console.WriteLine("bye!");
            Console.ReadKey();
        }
    }
}
