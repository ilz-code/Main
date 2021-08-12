namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private double _rate;

        public NewspaperAd(double fee, int column, double rate) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public override double Cost()
        {
            var fee = base.Cost() + _column * _rate;
            return fee;
        }

        public override string ToString()
        {
            return " NewspaperAd " + Cost();
        }
    }
}