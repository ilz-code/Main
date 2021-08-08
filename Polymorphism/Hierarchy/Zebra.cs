using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("\n Click");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetables)
                base.Eat(food);
            else
            {
                base.Eat(food);
                Console.WriteLine(" Zebras are not eating that type of food!");
                _foodEaten = 0;
            }
        }

        public override void Output()
        {
            Console.Write("\n Zebra ");
            base.Output();
        }
    }
}
