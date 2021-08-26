using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex2_CheckOddEvenTests
{
    [TestClass]
    public class CheckOddEvenTests
    {
        [DataTestMethod]
        [DataRow(12, "Even Number")]
        [DataRow(238, "Even Number")]
        [DataRow(11, "Odd Number")]
        [DataRow(357, "Odd Number")]
        public void IsOddOrEven_number_OddOrEven(int num, string result)
        {
            string answer = Ex2_CheckOddEven.OddEven.IsOddOrEven(num);
            Assert.AreEqual(result, answer);
        }
    }
}
