using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("\n Squeak");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetables)
                base.Eat(food);
            else
            {
                base.Eat(food);
                Console.WriteLine(" Mouses are not eating that type of food!");
                _foodEaten = 0;
            }
        }

        public override void Output()
        {
            Console.Write("\n Mouse ");
            base.Output();
        }
    }
}
