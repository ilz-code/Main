namespace AdApp
{
    class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _copies;
        private double _costPerArray;

        public Poster(int fee, int width, int height, int copies, double arrayCost) : base(fee)
        {
            _width = width;
            _height = height;
            _copies = copies;
            _costPerArray = arrayCost;
        }

        public override double Cost()
        {            
            return _width * _height * _costPerArray * _copies + base.Cost();
        }

        public override string ToString()
        {
            return " Poster " + Cost();
        }
    }
}
