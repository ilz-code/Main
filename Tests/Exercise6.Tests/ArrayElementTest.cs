using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise6.Tests
{
    [TestClass]
    public class ArrayElementTest
    {
        private ArrayElement _target;

        public ArrayElementTest()
        {
            _target = new ArrayElement();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            var result =_target.FindElement(firstArray, 9);
            Assert.AreEqual(-7, result);
        }
    }
}
