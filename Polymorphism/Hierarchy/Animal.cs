using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        public string _name;
        public double _weight;
        public int _foodEaten;

        public Animal()
        { }

        public Animal(string name, double weight)
        {
            _name = name;
            _weight = weight;
            _foodEaten = 0;
        }

        public virtual void MakeSound()
        { }

        public virtual void Eat(Food food)
        {
            _foodEaten = food.Quantity;
        }

        public virtual void Output()
        {
            Console.Write($" {_name} {_weight} ");
        }
    }
}
