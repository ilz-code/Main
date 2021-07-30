using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "..\\..\\midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);

            string[] words = readText.Split(' ');
            List<int> scores = new List<int>();
            foreach (string word in words)
            {
                scores.Add(int.Parse(word));
            }

            List<Mark> marks = new List<Mark>();
            for (int i =0; i <= 10; i++)
            {
               marks.Add( new Mark{Score = i, Count = 0 });
            }

            foreach (int score in scores)
            {
                foreach (Mark mark in marks)
                {
                    if (score >= mark.Score*10 && score < (mark.Score+1)*10-1)
                    {
                        mark.Count++;
                    }
                }
            }

            foreach (Mark mark in marks)
            {
                string m = (mark.Score * 10).ToString();
                if (m == "0")
                    m = "00";
                string n = ((mark.Score + 1) * 10 - 1).ToString();
                if (n == "9")
                    n = "09";
                string range = ($"{m}-{n}");
                if (m == "100")
                    range = "  100";
                string count = new string('*', mark.Count);
                Console.WriteLine($"{range}: {count}");
            }

            Console.ReadKey();
        }
    }
    class Mark
    {
        public int Score { get; set; }
        public int Count { get; set; }
    }
}
