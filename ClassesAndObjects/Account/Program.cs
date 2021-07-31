using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firstAccount = new Account("First account", 100.00);
            firstAccount.Deposit(20);
            firstAccount.Balance();

            var mat = new Account("Matt's account", 1000);
            var my = new Account("My account", 0);
            mat.Withdrawal(100);
            my.Deposit(100);
            mat.Balance();
            my.Balance();

            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account", 0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            aAccount.Balance();
            bAccount.Balance();
            cAccount.Balance();
            aAccount.Name = "GGGG";
            Transfer(aAccount, bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);

            Console.WriteLine("Final state");
            aAccount.Balance();
            bAccount.Balance();
            cAccount.Balance();

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
