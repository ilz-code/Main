using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private static void Main(string[] args)
        {
            string Path = "..\\..\\flights.txt";
            string[] readText = File.ReadAllLines(Path);

            List<Flight> flights = FlightPlaner.PossibleFlights(readText);
            HashSet<string> city = FlightPlaner.DepartingFrom(flights);
            Console.WriteLine("Flights are possible from:");
            Console.WriteLine(String.Join("\n", city));
            Console.WriteLine("\n Enter city from which flay:");
            string point = Console.ReadLine();
            List<string> flightPoints = new List<string>();
            string firstPoint = point;
            do
            {
                flightPoints.Add(point);
                Console.WriteLine($"\n From {point} flights are possible to:");
                foreach (Flight flight in flights)
                {
                    if (flight.CityFrom == point)
                        Console.WriteLine(flight.CityTo);
                }
                Console.WriteLine("\n Enter your destination");
                point = Console.ReadLine();
            }
            while (point != firstPoint);

            Console.WriteLine("\n Your round trip will be: " + String.Join(" -> ", flightPoints) + " -> " + point);

            Console.ReadKey();
        }
    }
}
