using System;
using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            
            persons.Add(new Student("Johan", "Steevens", "Baker Street 22, London", 317, 8.74));           
            persons.Add(new Employee("Albert", "Stein", "Homer Row 13, London", 111, "Professor"));
            foreach (Person person in persons)
            {
                person.Display();                
            }

            Console.ReadKey();
        }
    }
}