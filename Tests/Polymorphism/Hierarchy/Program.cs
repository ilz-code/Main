using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = Hierarhy.MakeAnimals();
            Food[] foods = Hierarhy.MakeFood();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Output());
                Console.WriteLine(animals[i].MakeSound());
                Console.WriteLine(animals[i].Eat(foods[i]));
            }

            Console.WriteLine();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.ReadKey();
        }
    }
}
