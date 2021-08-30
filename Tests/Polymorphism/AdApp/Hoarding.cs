namespace AdApp
{
    public class Hoarding: Advert
    {
        private double _rate;
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(int fee, int days, double rate, bool primeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = days;
            _primeLocation = primeLocation;
        }

        public override double Cost() 
        {
            double cost = _numDays * _rate;
            if (_primeLocation)
                cost *= 1.5;
            return cost + base.Cost();
        }

        public override string ToString() 
        {
            return " Hoarding " + Cost();
        }
    }
}