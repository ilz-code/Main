namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override string MakeSound()
        {
            return " Click";
        }

        public override string Eat(Food food)
        {
            string eat;
            if (food is Vegetables)
                eat = base.Eat(food);
            else
            {
                eat = base.Eat(food) + " Zebras are not eating that type of food!";
                _foodEaten = 0;
            }

            return eat;
        }

        public override string Output()
        {
            return "\n Zebra " + base.Output();
        }

        public override string ToString()
        {
            return "Zebra" + base.ToString() + $", {_foodEaten}]";
        }
    }
}
