using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex1_IsFifteenTests
{
    [TestClass]
    public class IsFifteenTest
    {
        [DataTestMethod]
        [DataRow(12, 15, true)]
        [DataRow(12, 3, true)]
        [DataRow(17, 2, true)]
        [DataRow(11, 26, true)]
        [DataRow(11, 9, false)]

        public void IsFifteen_twoNumbers_bool(int a, int b, bool q)
        {
            bool ansver = Ex1_IsFifteen.Fifteen.IsFifteen(a, b);
            Assert.AreEqual(q, ansver);
        }
    }
}
