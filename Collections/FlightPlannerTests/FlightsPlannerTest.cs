using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightPlanner;

namespace FlightPlannerTests
{
    [TestClass]
    public class FlightsPlannerTest
    {
        private List<Flight> flights = new List<Flight>();

       [TestMethod]
        public List<Flight> PossibleFlights_Flights()
        {
            string[] readText = {"San Jose -> San Francisco", "San Jose -> Anchorage", "New York->Anchorage", "New York -> San Jose"};
            flights = FlightPlaner.PossibleFlights(readText);
            string result = FlightPlaner.Output(flights[flights.Count-1]);
            string expect = "New York";
            Assert.AreEqual(expect, result);
            return flights;
        }

        [TestMethod]
        public void DepartingFrom_Flights_cities()
        {
            flights = PossibleFlights_Flights();
            HashSet<string> cities = FlightPlaner.DepartingFrom(flights);
            int result = cities.Count;
            int expect = 3;
            Assert.AreEqual(expect, result);
        }
    }
}
