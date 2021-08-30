using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firstAccount = new Accounts("First account", 100.00);
            firstAccount.Deposit(20);
            Console.WriteLine(firstAccount.Balance());

            var mat = new Accounts("Matt's account", 1000);
            var my = new Accounts("My account", 0);
            mat.Withdrawal(100);
            my.Deposit(100);
            Console.WriteLine(mat.Balance());
            Console.WriteLine(my.Balance());

            var aAccount = new Accounts("A account", 100.00);
            var bAccount = new Accounts("B account", 0);
            var cAccount = new Accounts("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount.Balance());
            Console.WriteLine(bAccount.Balance());
            Console.WriteLine(cAccount.Balance());
            aAccount.Name = "GGGG";
            Transfer(aAccount, bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);

            Console.WriteLine("Final state");
            Console.WriteLine(aAccount.Balance());
            Console.WriteLine(bAccount.Balance());
            Console.WriteLine(cAccount.Balance());

            Console.ReadKey();
        }

        public static void Transfer(Accounts from, Accounts to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
