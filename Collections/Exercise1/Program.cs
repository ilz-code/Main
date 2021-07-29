using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Tesla" };

            var list = new List<string>();
            list = array.ToList<string>();
            Console.WriteLine(String.Join(", ", list));
            
            HashSet<string> hset = new HashSet<string>();
            for (int i = 0; i < array.Length; i++)
            {
                hset.Add(array[i]);
            }
            Console.WriteLine(String.Join("; ", hset));

            string[] arc = { "Germany", "Germany", "Japan", "Germany", "Germany", "USA" };

            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < arc.Length; i++)
            {
                dict.Add(array[i], arc[i]);
            }           
            for(int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"{array[i]} is produced in {dict[array[i]]}");
            }
            Console.ReadKey();
        }
    }
}
