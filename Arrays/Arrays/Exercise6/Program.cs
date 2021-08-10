using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] firstArray = new int[10];

            //Random rnd = new Random();            
            //for (int i = 0; i < 10; i++)
            //    firstArray[i] = rnd.Next(100);

            //int[] secondArray = new int[10];
            //for (int i = 0; i < 10; i++)
            //    secondArray[i] = firstArray[i];

            //firstArray[9] = -7;

            //Console.WriteLine("Array 1: " + string.Join(" ", firstArray));
            //Console.WriteLine("Array 1: " + string.Join(" ", secondArray));

            int[] firstArray = ArrayElement.MakeArray();
           // int element = ArrayElement.FindElement(firstArray, 9);
            Console.WriteLine(firstArray);
            //Console.WriteLine(element);

            Console.ReadKey();
        }
    }
}
