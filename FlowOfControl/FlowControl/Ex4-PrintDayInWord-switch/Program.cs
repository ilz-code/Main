using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_PrintDayInWord_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of day (0 - 7)");
            string input = Console.ReadLine();

            string day;

            switch (input)
            {
                case "1":
                    day = "Monday";
                    break;
                case "2":
                    day = "Tuesday";
                    break;
                case "3":
                    day = "Wednesday";
                    break;
                case "4":
                    day = "Thursday";
                    break;
                case "5":
                    day = "Friday";
                    break;
                case "6":
                    day = "Saturday";
                    break;
                case "7":
                    day = "Sunday";
                    break;
                case "0":
                    day = "Sunday";
                    break;
                default:
                    day = "Invalid input!";
                        break;
            }
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
