using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Date today = new Date(27, 07, 2021);
            Console.WriteLine(today.DisplayData());

            Console.ReadKey();
        }
    }
}
