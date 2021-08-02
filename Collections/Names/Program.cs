using System;
using System.Collections.Generic;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "OK";
            HashSet<string> names = new HashSet<string>();
            while (input != "")
            {
                Console.WriteLine("Enter name: ");
                input = Console.ReadLine();
                names.Add(input);
            }
            Console.WriteLine("Unique name list contains: " + String.Join(", ", names));

            Console.ReadKey();
        }
    }
}
