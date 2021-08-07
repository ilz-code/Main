using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Tiger : Felime
    {
        public Tiger(string name, int weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("Growl");
        }

        public override void Eat(Food food, int quantity)
        {
            if (food is Meat)
                base.Eat(food, quantity);
            else
                Console.WriteLine("Tigers are not eating that type of food!");
        }
    }
}
