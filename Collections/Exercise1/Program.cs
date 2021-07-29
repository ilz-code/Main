using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Tesla" };

            //todo - replace array with an List and print out the results

            //todo - replace array with a HashSet and print out the results

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
            var list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            Console.WriteLine(String.Join(", ", array));

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
            Console.WriteLine($"BMW is produced in {dict["BMW"]}");
           // foreach (KeyValuePair car in dict)
            {

            }
            Console.ReadKey();
        }

    }
}
