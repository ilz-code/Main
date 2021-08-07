using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Food
    {
        private int _quantity;       

        public Food()
        {

        }

        public Food(int quantity)
        {
            _quantity = quantity;
        }
    }
}
