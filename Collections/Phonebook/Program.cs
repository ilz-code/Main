using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string number;
            SortedDictionary<string, string> phones = new SortedDictionary<string, string>();
            
            int choose;
            do
            {
                Console.WriteLine("\n Find number: 1 \n Add number: 2 \n End work: 0 \n What do You want to do?");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        FindNumber();
                        break;
                    case 2:
                        AddNumber();
                        break;
                }
            }
            while (choose != 0);

            void FindNumber()
            {
                try
                {
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine(phones[name]);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine($"Name {name} is not found.");
                }                
            }

            void AddNumber()
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter number: ");
                number = Console.ReadLine();
                if (number.Length != 8)
                    Console.WriteLine("Number must consist from 8 digits!");
                try
                {
                    phones.Add(name, number);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Name {name} already exists.");
                }                   
            }
        }
    }
}
