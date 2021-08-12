using System;

namespace Phonebook
{
    class Program
    {
        static string name = "";
        static string number;

        static void Main(string[] args)
        {
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
            } while (choose != 0);

            void FindNumber()
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine(PhoneBook.Finder(name));
            }

            void AddNumber()
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter number: ");
                number = Console.ReadLine();
                if (number.Length != 8)
                    Console.WriteLine("Number must consist from 8 digits!");
                Console.WriteLine(PhoneBook.Adder(name, number));
            }
        }
    }
}
