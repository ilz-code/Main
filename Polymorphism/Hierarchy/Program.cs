using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string[] lines = File.ReadAllLines("..\\..\\..\\animals.txt");
            string animalType;
            string name;
            double weight;
            string region;
            string breed;
            string foodType;
            int quantity;
            for (int i = 0; i < lines.Length - 1; i += 2)
            {
                string[] words = lines[i].Split(' ');
                animalType = words[0];
                name = words[1];
                weight = Convert.ToDouble(words[2]);
                region = words[3];
                if (animalType == "Cat")
                    breed = words[4];
                else
                    breed = "";

                Animal animal = null;
                switch (animalType)
                {
                    case "Cat":
                        animal = new Cat(name, weight, region, breed);
                        break;
                    case "Zebra":
                        animal = new Zebra(name, weight, region);
                        break;
                    case "Mouse":
                        animal = new Mouse(name, weight, region);
                        break;
                    case "Tiger":
                        animal = new Tiger(name, weight, region);
                        break;
                }
                animals.Add(animal);

                animal.Output();
                animal.MakeSound();

                string[] food = lines[i + 1].Split(' ');
                foodType = food[0];
                quantity = int.Parse(food[1]);

                Food eat = null;
                switch (foodType)
                {
                    case "Meat":
                        eat = new Meat(quantity);
                        break;
                    case "Vegetables":
                        eat = new Vegetables(quantity);
                        break;
                }

                animal.Eat(eat);                
            }

            Console.WriteLine();
            foreach (Animal animal in animals)
            {
               // Console.WriteLine(JsonConvert.SerializeObject(animal));
            }

            Console.ReadKey();
        }
    }
}