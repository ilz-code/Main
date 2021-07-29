using System;

namespace SavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting balance: ");
            double startingBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter annual interest: ");
            double annualInterest = Convert.ToDouble(Console.ReadLine());
            SavingsAccount user = new SavingsAccount(startingBalance, annualInterest);
            Console.WriteLine("How long (in months) account is opened? ");
            int months = int.Parse(Console.ReadLine());
            double sumDeposited = 0;
            double sumWithdrawed = 0;
            double sumInterest = 0;
            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine("Enter amount deposited in mounth" + i);
                double depos = Convert.ToDouble(Console.ReadLine());
                sumDeposited += depos;
                user.Deposit(depos);
                Console.WriteLine("Enter sum withdrawed in month " + i);
                double withdraw = Convert.ToDouble(Console.ReadLine());
                sumWithdrawed += withdraw;
                user.Withdraw(withdraw);
                double monthInterest= user.MonthlyInterest();
                user.Balance += monthInterest;
                sumInterest += monthInterest;
            }
            Console.WriteLine("Total deposited: $" + sumDeposited);
            Console.WriteLine("Total withdrawn: $" + sumWithdrawed);
            Console.WriteLine("Interest earned: $" + Math.Round(sumInterest, 2));
            Console.WriteLine("Ending balance: $" + Math.Round(user.Balance, 2));

            Console.ReadKey();
        }
    }
}
