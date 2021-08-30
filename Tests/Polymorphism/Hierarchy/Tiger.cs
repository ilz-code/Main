namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override string MakeSound()
        {
            return " Growl";
        }

        public override string Eat(Food food)
        {
            string eat;
            if (food is Meat)
                eat = base.Eat(food);
            else
            {
                _foodEaten = 0;
                eat = base.Eat(food) + "\n Tigers are not eating that type of food!";
            }

            return eat;
        }

        public override string Output()
        {
            return "\n Tiger " + base.Output();
        }

        public override string ToString()
        {
            return "Tiger" + base.ToString() + $", {_foodEaten}]";
        }
    }
}
