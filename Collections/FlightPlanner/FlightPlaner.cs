using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
   public class FlightPlaner
    {
       private const string Path = "..\\..\\flights.txt";
       private static string[] readText = File.ReadAllLines(Path);

        public static List<Flight> PossibleFlights(string[] readText)
        {
            List<Flight> flights = new List<Flight>();
            foreach (var s in readText)
            {
                string[] cities = s.Split('>');
                string a = cities[0].Substring(0, cities[0].Length - 2);
                string b = cities[1].Substring(1);
                flights.Add(new Flight { CityFrom = a, CityTo = b });
            }
            return flights;
        }

        public static HashSet<string> DepartingFrom(List<Flight> flights)
        {
            HashSet<string> city = new HashSet<string>();
            foreach (Flight flight in flights)
            {
                city.Add(flight.CityFrom);
            }
            return city;
        }

        public static string Output(Flight fly)
        {
            return fly.CityFrom;
        }
    }

    public class Flight
    {
        public string CityFrom;
        public string CityTo;
    }
}
