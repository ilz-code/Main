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
            firstAccount.deposit(20);
            firstAccount.balance();

            var mat = new Account("Matt's account", 1000);
            var my = new Account("My account", 0);
            mat.withdrawal(100);
            my.deposit(100);
            mat.balance();
            my.balance();

            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account", 0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            aAccount.balance();
            bAccount.balance();
            cAccount.balance();
            aAccount.Name = "GGGG";
            Transfer(aAccount, bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);

            Console.WriteLine("Final state");
            aAccount.balance();
            bAccount.balance();
            cAccount.balance();

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
