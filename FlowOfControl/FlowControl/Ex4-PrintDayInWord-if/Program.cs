using System;

namespace Ex4_PrintDayInWord_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of day (0 - 7)");
            var input = Console.ReadLine();

            string day;

            if (input == "1")
                day = "Monday";
            else if (input == "2")
                day = "Tuesday";
            else if (input == "3")
                day = "Wednesday";
            else if (input == "4")
                day = "Thursday";
            else if (input == "5")
                day = "Friday";
            else if (input == "6")
                day = "Saturday";
            else if (input == "7" || input == "0")
                day = "Sunday";
            else
                day = "Invalid input!";

            Console.WriteLine(day);
            Console.ReadKey();
        }       
    }
}
