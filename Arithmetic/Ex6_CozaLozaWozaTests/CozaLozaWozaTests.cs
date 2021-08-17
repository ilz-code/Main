using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ex6_CozaLozaWozaTests
{
    [TestClass]
    public class CozaLozaWozaTests
    {
        [DataTestMethod]
        [DataRow (105, " CozaLozaWoza")]
        [DataRow (70, " LozaWoza")]
        [DataRow (21, " CozaWoza")]
        [DataRow (45, " CozaLoza")]
        [DataRow (12, " Coza")]
        [DataRow (25, " Loza")]
        [DataRow (14, " Woza")]
        [DataRow (17, " 17")]
        public void CozaLoza_number_CozaLoza(int num, string output)
        {
            string result = Ex6_CozaLozaWoza.CozaLozaWoza.CozaLoza(num);
            Assert.AreEqual(output, result);
        }
    }
}
