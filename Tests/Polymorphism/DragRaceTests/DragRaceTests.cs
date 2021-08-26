using DragRace;
using Xunit;
using System.Collections.Generic;

namespace DragRaceTests
{
    public class DragRaceTests
    {
        public static List<ICar> cars = new List<ICar>();

        [Fact]
        public void MakeCarsList_CountOfCarsInList()
        {
            int result = Dragrace.MakeCarsList().Count;
            int expect = 6;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Competition_carLocCount()
        {
            int result = Dragrace.Competition(Dragrace.MakeCarsList()).Count;
            int expect = 6;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Visualization_ExpectedMaxTimes()
        {
            int result = Dragrace.Visualization();
            int expect = 100;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Results_distExpected()
        {
            int result = Dragrace.Results();
            int expect = 6;
            Assert.Equal(expect, result);
        }
    }
}
