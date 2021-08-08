using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        string _breed;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("\n Meoww");
        }

        public override void Eat(Food food)
        {
            base.Eat(food);
        }

        public override void Output()
        {
            Console.Write("\n Cat ");
            base.Output();
            Console.Write(" " + _breed);
        }
    }
}
