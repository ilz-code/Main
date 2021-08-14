namespace Hierarchy
{
   public class Cat : Felime
    {
        string _breed;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return " Meoww";
        }

        public override string Eat(Food food)
        {
            return base.Eat(food);
        }

        public override string Output()
        {
            return "\n Cat " + base.Output() + " " + _breed;
        }

        public override string ToString()
        {
            return $"Cat[{_name}, {_breed}, {_weight}, {_livingRegion}, {_foodEaten}]";
        }
    }
}
