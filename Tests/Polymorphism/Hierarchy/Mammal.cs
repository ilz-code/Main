namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion;

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            _livingRegion = livingRegion;
        }

        public override string Eat(Food food)
        {
           return base.Eat(food);
        }

        public override string Output()
        {
            base.Output();
            return _livingRegion;
        }

        public override string ToString()
        {
            return $"[{_name}, {_weight}, {_livingRegion}";
        }
    }
}
