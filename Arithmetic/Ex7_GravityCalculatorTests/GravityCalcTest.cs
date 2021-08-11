using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex7_GravityCalculatorTests
{
    [TestClass]
    public class GravityCalcTest
    {
        [DataTestMethod]
        [DataRow(0, 10, 0, 490.5)]
        [DataRow(-10, 10, 0, 480.5)]
        [DataRow(0, 10, -3, 460.5)]
        public void GravityCalculation_startAndTime_finalPosition(double pos, double time, double velocity, double position)
        {
            double result = Ex7_GravityCalc.GravityCalculator.GravityCalculation(pos, time, velocity);
            Assert.AreEqual(position, result);
        }
    }
}
