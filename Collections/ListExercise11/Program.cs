using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> flowers = new List<string>();

            flowers.Add("rose");
            flowers.Add("lily");
            flowers.Add("daisy");
            flowers.Add("hydrangea");
            flowers.Add("sunflower");
            flowers.Add("peony");
            flowers.Add("narcissus");
            flowers.Add("calendula");
            flowers.Add("gladiolus");
            flowers.Add("carnation");

            flowers.Insert(4, "violet");

            flowers[flowers.Count()-1] = "swab";

            flowers.Sort();

            Console.WriteLine(flowers.Contains("Foobar"));

            for (int i = 0; i < flowers.Count(); i++)
            {
                Console.WriteLine(flowers[i]);
            }

            Console.ReadKey();
        }
    }
}
