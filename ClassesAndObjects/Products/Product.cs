using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        string name;
        double price;
        int amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.price = priceAtStart;
            this.amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}, price {price}, amount {amount}");
        }

        public void ChangeQuantity(int quantityChanges)
        {
            amount += quantityChanges;
        }

        public void ChangePrice(double priceChanges)
        {
            price += priceChanges;
        }
    }
}
