using System;
using System.IO;

namespace Hierarchy
{
    public class Hierarhy
    {
        public static Animal[] MakeAnimals()
        {
            string[] lines = File.ReadAllLines("..\\..\\..\\animals.txt");
            Animal[] animals = new Animal[lines.Length / 2];
           
            string animalType;
            string name;
            double weight;
            string region;
            string breed;
            
            int k = 0;
            for (int i = 0; i < lines.Length; i += 2)
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

                Type animalClassType = Type.GetType($"Hierarchy.{animalType}", true);
                if (animalType == "Cat")
                    animals[k] = (Animal)Activator.CreateInstance(animalClassType, name, weight, region, breed);
                else
                    animals[k] = (Animal)Activator.CreateInstance(animalClassType, name, weight, region);
                k++;
            }
            return animals;
        }

        public static Food[] MakeFood()
        {
            string foodType;
            int quantity;
            int k = 0;
            string[] lines = File.ReadAllLines("..\\..\\..\\animals.txt");
            Food[] foods = new Food[lines.Length / 2];
            for (int i = 0; i < lines.Length; i += 2)
            {
                string[] food = lines[i + 1].Split(' ');
                foodType = food[0];
                quantity = int.Parse(food[1]);
                Type foodClassType = Type.GetType($"Hierarchy.{foodType}", true);
                foods[k] = (Food)Activator.CreateInstance(foodClassType, quantity);
                k++;
            }
            return foods;
        }
    }
}
