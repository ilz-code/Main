using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Meat : Food
    {
        public Meat()
        { }
         public Meat(int quantity) : base(quantity)
        {
            Name = "Vegetables";
        }
    }
}
