using System;

namespace _7_UpperCaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            int countUppers = 0;
            for (int i = 0; i < input.Length; i++)
            {
               if(Char.IsUpper(input, i)) { countUppers += 1; }                
            }
            Console.WriteLine($"Your string contains {countUppers} uppercase letters");
            Console.ReadKey();
        }
    }
}
