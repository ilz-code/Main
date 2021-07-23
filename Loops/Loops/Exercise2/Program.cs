using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j, ans;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                ans = 1;
                for (j=1; j <= n; j++)
                {
                    ans *= i;
                }
              Console.WriteLine($"{i}^{n} = {ans}");
            }
            Console.ReadKey();
        }
    }
}
