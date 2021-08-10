using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Exercise6.Tests
{
    [TestClass]
    public class ArrayElementTest
    {
        
        [TestMethod]
        public void FindElement_ArrayAndIndex_Element()
        {
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            var result =ArrayElement.FindElement(firstArray, 9);
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void MakeArray_NewArray()
        {
            var arrayLength = ArrayElement.MakeArray().Length;
            Assert.AreEqual(10, arrayLength);
        }

        [TestMethod]
        public void CopyArray_oneArray_otherArray()
        {
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            int[] secondArray = ArrayElement.CopyArray(firstArray);
            bool equals = firstArray.SequenceEqual(secondArray);
            Assert.AreEqual(true, equals);
        }

    }
}
