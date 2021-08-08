using System;

namespace Hierarchy
{
    class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("\n Growl");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
                base.Eat(food);
            else
            {
                base.Eat(food);
                Console.WriteLine(" Tigers are not eating that type of food!");
                _foodEaten = 0;
            }
        }

        public override void Output()
        {
            Console.Write("\n Tiger ");
            base.Output();
        }

        public override string ToString()
        {
            return "Tiger" + base.ToString() + $", {_foodEaten}]";
        }
    }
}
