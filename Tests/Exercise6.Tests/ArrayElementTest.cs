using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise6.Tests
{
    [TestClass]
    public class ArrayElementTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            var result =ArrayElement.FindElement(firstArray, 9);
            Assert.AreEqual(-7, result);
        }
    }
}
