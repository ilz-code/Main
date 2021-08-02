using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            
            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("Brown");
            colors.Add("Blue");

            Console.WriteLine(String.Join(", ", colors));
            Console.ReadKey();
        }
    }
}
