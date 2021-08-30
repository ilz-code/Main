using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        Product product = new Product("Display", 333, 4);

        [TestMethod]
        public void PrintProduct_ProductName_ProductAsString()
        {
            string result = product.PrintProduct();
            string expected = "Display, price 333, amount 4";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeQuantity_quantityChanges_NewAmount()
        {
            int result = product.ChangeQuantity(3);
            int expected = 7;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangePrice_priceChange_NewPrice()
        {
            double result = product.ChangePrice(13);
            double expected = 346;
            Assert.AreEqual(expected, result);
        }
    }
}
