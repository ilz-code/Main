﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra : Mammal
    {
        public Zebra(string name, int weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("Click");
        }

        public override void Eat(Food food, int quantity)
        {
            if (food is Vegetables)
                base.Eat(food, quantity);
            else
                Console.WriteLine("Zebras are not eating that type of food!");
        }
    }
}
