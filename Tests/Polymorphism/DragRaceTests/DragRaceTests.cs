using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRaceTests
{
    [TestClass]
    public class DragRaceTests
    {
        [TestMethod]
        public void MakeCarsList_cars()
        {
            int result = Dragrace.MakeCarslist().Count;
            int expect = 6;
            Assert.AreEqual(expect, result);
        }
    }
}
