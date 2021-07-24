using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("\n Vowels are: ");
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(" " + vowels[i]);
            }

            Console.Write("\n Vowels are: ");
            foreach (char v in vowels)
            {
                Console.Write(" " + v);
            }

            Console.ReadKey();
        }
    }
}
