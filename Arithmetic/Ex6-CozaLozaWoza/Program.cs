using System;

namespace Ex6_CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=110; i++)
            {
                if ((i - 1) % 11 == 0)
                    Console.WriteLine();
                Console.Write(CozaLozaWoza.CozaLoza(i));             
            }
            Console.ReadKey();
        }
    }
}
