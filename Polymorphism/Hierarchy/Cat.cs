using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        string _breed;

        public Cat(string name, int weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meoww");
        }

        public override void Eat(Food food, int quantity)
        {
            base.Eat(food, quantity);
        }
    }
}
