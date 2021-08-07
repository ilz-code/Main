using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string name, int weight, string livingRegion) : base(name, weight)
        {
            _livingRegion = livingRegion;
        }

        public override void Eat(Food food, int quantity)
        {
            base.Eat(food, quantity);
        }
    }
}
