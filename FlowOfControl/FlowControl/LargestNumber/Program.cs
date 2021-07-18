using System;

namespace LargestNumber
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            double largest;

            if (input1 > input2 && input1 > input3)
                largest = input1;
            else if (input2 > input1 && input2 > input3)
                largest = input2;
            else
                largest = input3;
            
            Console.WriteLine($"Largest number is {largest}");
            Console.ReadKey();           
        }
    }
}
