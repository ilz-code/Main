using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                 var tekst = File.ReadAllText("..\\..\\lear.txt");
                //StreamReader sr = new StreamReader("..\\..\\lear.txt");
                line = sr.ReadLine();

                //C: \\Users\ilzep\Documents\GitHub\Main\Collections\WordCount\

                //while (line != null)
                //{
                //write the lie to console window
                Console.WriteLine(line);
                //Read the next line
                // line = sr.ReadLine();
                // }

                //sr.Close();
                //string[] words = String.Split(" ",);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("xx");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
