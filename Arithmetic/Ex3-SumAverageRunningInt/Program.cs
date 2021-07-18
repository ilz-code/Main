using System;

namespace Ex3_SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 100;
            int sum = 0;
            int count = 0;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                sum += i;
                ++count;
            }
            double sumD = sum;
            double average = sumD / count;

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.ReadKey();
        }
    }
}
