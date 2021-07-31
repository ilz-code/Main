using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        public static void Main(string[] args)
        {        
            Product mouse = new Product("Logitech mouse", 70.00, 14);
            Product iPhone = new Product("iPhone 5s", 999.99, 3);
            Product epson = new Product("Epson EB-U05", 440.46, 1);

            mouse.ChangeQuantity(-5);
            iPhone.ChangePrice(-100);

            mouse.PrintProduct();
            iPhone.PrintProduct();
            epson.PrintProduct();

            Console.ReadKey();
        }
    }
}
