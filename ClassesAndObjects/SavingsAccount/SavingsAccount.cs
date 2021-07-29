namespace SavingsAccount
{
    public class SavingsAccount
    {
        public double AnnualInterest { get; set; }
        public double Balance { get; set; }

        public SavingsAccount(double startingBalance, double annualInterest)
        {
            Balance = startingBalance;
            AnnualInterest = annualInterest;
        }

        public void Withdraw(double amountToWithdraw)
        {
            Balance -= amountToWithdraw;
        }

        public void Deposit(double amountOfDeposit)
        {
            Balance += amountOfDeposit;
        }

        public double MonthlyInterest()
        {
            return Balance * AnnualInterest / 1200;
        }
    }
}
