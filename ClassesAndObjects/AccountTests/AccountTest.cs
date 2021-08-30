using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            //Act
            double result = tAccount.Withdrawal(313);
            //Assert
            double expected = 313;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Deposit_AmountDeposited_AccountTotal()
        {
            //Act
            double result = tAccount.Deposit(250);
            //Assert
            double expected = 1250;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Balance_Account_BalanceAsString()
        {
            //Act
            string result = tAccount.Balance();
            //Assert
            string expected = "testAcc: 1000";
            Assert.AreEqual(expected, result);
        }
    }
}
