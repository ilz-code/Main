using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_NameAndYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter year of birth");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"My name is {name} and I was born in {year}.");
            Console.ReadKey();
        }
    }
}
