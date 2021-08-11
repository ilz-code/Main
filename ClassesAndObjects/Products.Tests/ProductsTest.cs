using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        Product product = new Product("Display", 333, 4);

        [TestMethod]
        public void PrintProduct_name_string()
        {
            string result = product.PrintProduct();
            string expected = "Display, price 333, amount 4";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeQuantity_quantityChanges_amount()
        {
            int result = product.ChangeQuantity(3);
            int expected = 7;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangePrice_priceChange_change()
        {
            double result = product.ChangePrice(13);
            double expected = 346;
            Assert.AreEqual(expected, result);
        }
    }
}
