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

    class Account
    {
        private string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                _balance = Math.Abs(_balance);
                return $"{_name}, -${_balance:0.00}";
            }
            return $"{_name}, ${_balance:0.00}";
        }
    }
}
