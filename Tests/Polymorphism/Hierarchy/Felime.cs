namespace Hierarchy
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override string Eat(Food food)
        {
            return base.Eat(food);
        }

        public override string Output()
        {
            return base.Output();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
