using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Felime : Mammal
    {
        public Felime(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void Eat(Food food)
        {
            base.Eat(food);
        }

        public override void Output()
        {
            base.Output();
        }
    }
}
