namespace AdApp
{
    public class Advert
    {
        private double _fee;

        public Advert() 
        {
            _fee = 0;
        }

        public Advert(double fee) 
        {
            _fee = fee;
        }
                
        public virtual double Cost() 
        {
            return _fee;
        }        
    }
}