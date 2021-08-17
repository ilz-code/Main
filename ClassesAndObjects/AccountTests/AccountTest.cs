using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Account;

namespace AccountTests
{
    [TestClass]
    public class AccountTest
    {
        Accounts tAccount = new Accounts("testAcc", 1000);

        [TestMethod]
        public void Withdrawal_ToWithdraw_Withdrawn()
        {
            double result = tAccount.Withdrawal(313);
            double expected = 313;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Deposit_AmountDeposited_AccountTotal()
        {
            double result = tAccount.Deposit(250);
            double expected = 1250;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Balance_Account_BalanceAsString()
        {
            string result = tAccount.Balance();
            string expected = "testAcc: 1000";
            Assert.AreEqual(expected, result);
        }
    }
}
