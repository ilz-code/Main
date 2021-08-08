using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        public string _livingRegion;

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            _livingRegion = livingRegion;
        }

        public override void Eat(Food food)
        {
            base.Eat(food);
            Console.WriteLine(" " + food.Name + " " + food.Quantity);
        }

        public override void Output()
        {
            base.Output();
            Console.Write(_livingRegion);
        }
    }
}
