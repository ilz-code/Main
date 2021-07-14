using System;

namespace _6_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some one-digit numbers");
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            int[] numArr = new int[input.Length];
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                numArr[i] = charArr[i];
                sum += numArr[i] -48;                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
