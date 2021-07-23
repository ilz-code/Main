using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sum (2 - 12):");
            int desired = Int32.Parse(Console.ReadLine());
            int sum = 0;
            var rnd = new Random();

            do
            {
                int roll1 = rnd.Next(1, 6);
                int roll2 = rnd.Next(1, 6);
                sum = roll1 + roll2;
                Console.WriteLine($"{roll1} and {roll2} = {sum}");

            } while (sum != desired);
            Console.ReadKey();
        }
    }
}
