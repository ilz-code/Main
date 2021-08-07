using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Felime : Mammal
    {
        public Felime(string name, int weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void Eat(Food food, int quantity)
        {
            base.Eat(food, quantity);
        }
    }
}
