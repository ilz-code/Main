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

            float dFloat = Convert.ToSingle(d);

            float sum =  a + b + c + dFloat + e;
            
            Console.WriteLine(sum);
        }
    }
}
