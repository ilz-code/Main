using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;
            
            int sum = a + b + c + (int)d + (int)e;
            Console.WriteLine(sum);
        }

        static void Second()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            double sum = Math.Round( a + b + c + d + e, 1);
            Console.WriteLine(sum);
        }
    }
}
