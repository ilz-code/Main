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
            //Arrange
            string[] readText = {"San Jose -> San Francisco", "San Jose -> Anchorage", "New York->Anchorage", "New York -> San Jose"};
            //Act
            flights = FlightPlaner.PossibleFlights(readText);
            //Assert
            string result = FlightPlaner.Output(flights[flights.Count-1]);
            string expect = "New York";
            Assert.AreEqual(expect, result);
            return flights;
        }

        [TestMethod]
        public void DepartingFrom_Flights_citiesCount()
        {
            //Arrange
            flights = PossibleFlights_Flights();
            //Act
            HashSet<string> cities = FlightPlaner.DepartingFrom(flights);
            //Assert
            int result = cities.Count;
            int expect = 3;
            Assert.AreEqual(expect, result);
        }
    }
}
