using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Exercise6.Tests
{
    [TestClass]
    public class ArrayElementTest
    {
        [TestMethod]
        public void FindElement_ArrayAndIndex_Element()
        {
            //Arrange
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            //Act
            var result =ArrayElement.FindElement(firstArray, 9);
            //Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void MakeArray_NewArray_ArrayLength()
        {
            //Act
            var arrayLength = ArrayElement.MakeArray().Length;
            //Assert
            Assert.AreEqual(10, arrayLength);
        }

        [TestMethod]
        public void CopyArray_oneArray_otherArray()
        {
            //Arrange
            int[] firstArray = { 21, 8, 81, 50, 76, 6, 32, 46, 1, -7 };
            //Act
            int[] secondArray = ArrayElement.CopyArray(firstArray);
            //Assert
            bool equals = firstArray.SequenceEqual(secondArray);
            Assert.AreEqual(true, equals);
        }
    }
}
