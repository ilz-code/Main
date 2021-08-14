namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override string MakeSound()
        {
            return " Squeak";
        }

        public override string Eat(Food food)
        {
            string eat;
            if (food is Vegetables)
                eat = base.Eat(food);
            else
            {
                eat = base.Eat(food) + " Mouses are not eating that type of food!";
                _foodEaten = 0;
            }

            return eat;
        }

        public override string Output()
        {
            return "\n Mouse " + base.Output();
        }

        public override string ToString()
        {
            return "Mouse" + base.ToString() + $", {_foodEaten}]";
        }
    }
}
