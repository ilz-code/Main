using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateTest;

namespace DateTestTests
{
    [TestClass]
    public class DateTest
    {
        private Date date = new Date(11, 8, 2021);

        [TestMethod]
        public void DisplayDate_Date()
        {
            string result = date.DisplayData();
            string expected = "11/08/2021";
            Assert.AreEqual(expected, result);
        }
    }
}
