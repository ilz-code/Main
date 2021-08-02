using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "..\\..\\flights.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            List<Flight> flights = new List<Flight>();
            HashSet<string> city = new HashSet<string>();
            string[] cities;
            List<string> flightPoints = new List<string>();

            foreach (var s in readText)
            {
                cities = s.Split('>');
                string a = cities[0].Substring(0, cities[0].Length - 2);
                string b = cities[1].Substring(1);
                flights.Add(new Flight { CityFrom = a, CityTo = b });
            }

            Console.WriteLine("Flights are possible from:");
            foreach (Flight flight in flights)
            {
                city.Add(flight.CityFrom);
            }
            Console.WriteLine(String.Join("\n", city));
            Console.WriteLine("\n Enter city from which flay:");
            string point = Console.ReadLine();
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
    public class Flight
    {
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
    }
}
