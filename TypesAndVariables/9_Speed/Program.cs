using System;

namespace _9_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance (in meters)");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time. Hours:");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Minutes:");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seconds:");
            double seconds = Convert.ToDouble(Console.ReadLine());
            double speedMetersInSecond = Math.Round(distance / (hours * 3600 + minutes * 60 + seconds), 8);
            double speedKilometersInHour = Math.Round(speedMetersInSecond * 3.6, 8);
            double speedMilesInHour = Math.Round(speedKilometersInHour / 1.609, 8);
           
            Console.WriteLine($"Your speed in meters/second is {speedMetersInSecond}");
            Console.WriteLine($"Your speed in km/h is {speedKilometersInHour}");
            Console.WriteLine($"Your speed in miles/h is {speedMilesInHour}");
            Console.ReadKey();
        }
    }
}
