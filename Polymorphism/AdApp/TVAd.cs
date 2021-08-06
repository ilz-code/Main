namespace AdApp
{
    public class TVAd: Advert
    {
        private int _time;
        private double _rate;
        private bool _peakHours;

        public TVAd(int fee, int time, int rate, bool peakHours) : base(fee)
        {
            _time = time;
            _rate = rate;
            _peakHours = peakHours;
        }
        
        public override double Cost() 
        {
            double cost = _time * _rate;
            if (_peakHours)
                cost *= 1.5;
            return base.Cost() +cost;
        }

        public override string ToString() 
        {
            return " TVAd " + Cost();
        }
    }
}