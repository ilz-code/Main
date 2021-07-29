using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account jon = new Account("Johan K. Andersen", 170000);
            Account bob = new Account("Robert Steevens", -777.897);

            Console.WriteLine(jon.ShowUserNameAndBalance());
            Console.WriteLine(bob.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }

    public class Account
    {
        public string Name;
        public double Balance;

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (Balance < 0)
            {
                Balance = Math.Abs(Balance);
                return $"{Name}, -${Balance:0.00}";
            }
            return $"{Name}, ${Balance:0.00}";
        }
    }
}
