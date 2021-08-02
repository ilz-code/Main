using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var tex = File.ReadAllText("..\\..\\lear.txt");

            string[] lines = tex.Split('\n');
            Console.WriteLine("Lines = " + lines.Length);

            string[] words = tex.Split('\'', ' ', '\n');
            Console.WriteLine("Words = " + words.Length);

            char[] chars = tex.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if (Char.IsLetterOrDigit(c))
                    count++;
            }
            Console.WriteLine("Chars = " + count);

            Console.ReadKey();

        }
    }
}
