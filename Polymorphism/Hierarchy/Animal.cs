using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        private string _name;
        private double _weight;
        private int _foodEaten;

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

        public virtual void Eat(Food food, int quantity)
        {
            _foodEaten = quantity;
        }
    }
}
