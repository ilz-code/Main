using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ex8_EmployeePayTests
{
    [TestClass]
    public class EmployeePayTest
    {
        [DataTestMethod]
        [DataRow(6.7, 45, "Base pay must be at least 8 $ per hour!")]
        [DataRow(9, 75, "Worked hours may not exceed 60!")]
        [DataRow(8, 30, "240")]
        [DataRow(10, 50, "550")]
        public void ToPay_hoursAndHourPay_Pay(double hourPay, double workedHours, string pay)
        {
            string result = Ex8_EmployeePay.EmployeePay.ToPay(hourPay, workedHours);
            Assert.AreEqual(pay, result);
        }
    }
}
