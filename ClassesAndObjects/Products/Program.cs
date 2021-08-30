using System;

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

            Console.WriteLine(mouse.PrintProduct());
            Console.WriteLine(iPhone.PrintProduct());
            Console.WriteLine(epson.PrintProduct());

            Console.ReadKey();
        }
    }
}
