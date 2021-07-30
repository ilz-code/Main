using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            List<char> chars = new List<char>();
            List<double> nums = new List<double>();
            do
            {
                chars.Clear();
                nums.Clear();
                chars = number.ToList<char>();
                foreach (char c in chars)
                {
                    nums.Add(Math.Pow((Convert.ToInt32(c) - 48), 2));
                }
                number = Convert.ToString(nums.Sum());               
            }
            while (number.Length > 1);

            if (number == "1")
                Console.WriteLine("Number is happy");
            else
                Console.WriteLine("Number is not happy");

            Console.ReadKey();
        }
    }
}
