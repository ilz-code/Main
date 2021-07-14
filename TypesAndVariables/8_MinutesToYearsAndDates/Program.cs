using System;

namespace _8_MinutesToYearsAndDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter large number");
            int input = Convert.ToInt32(Console.ReadLine());
            double days = input / (24 * 60);
            double years = days / 365;
            int daysInt = Convert.ToInt32(days);
            int yearsInt = Convert.ToInt32(Math.Floor(years));
            int daysLeft = daysInt - yearsInt * 365;
            Console.WriteLine($"{input} minutes corresponds to {yearsInt} years and {daysLeft} days.");
            Console.ReadKey();
        }
    }
}
