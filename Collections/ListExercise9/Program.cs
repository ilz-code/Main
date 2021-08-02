using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            List<string> secondList = new List<string>(firstList);
            secondList.Sort();

            Console.WriteLine(string.Join(",", secondList));

            var mergedList = firstList.Concat(secondList);

            Console.WriteLine(string.Join(",", mergedList));
            Console.ReadKey();
        }
    }
}
