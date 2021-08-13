using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRaceTests
{
    [TestClass]
    public class DragRaceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = DragRace.Dragrace.MakeCarsList().Count;
        }
    }
}
