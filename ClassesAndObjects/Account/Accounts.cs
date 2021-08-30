namespace Account
{
    public class Accounts
    {
        private string _name;
        private double _money;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Accounts(string v1, double v2)
        {           
            _name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public double Deposit(double i)
        {
            _money += i;
            return _money;
        }

        public string Balance()
        {
           return ToString();
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}
