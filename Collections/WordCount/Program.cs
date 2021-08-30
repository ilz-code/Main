using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var tex = File.ReadAllText("..\\..\\lear.txt");

            Console.WriteLine(WordCount.CountWords.CountLines(tex));
            Console.WriteLine(WordCount.CountWords.CountWord(tex));
            Console.WriteLine(WordCount.CountWords.CountChars(tex));

            Console.ReadKey();
        }
    }
}
