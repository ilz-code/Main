using System;
using System.IO;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {


            //input = File.ReadAllText("..\\..\\animals");
            string[] lines = File.ReadAllLines("..\\..\\..\\animals.txt");//input.Split('\n');
            string animalType;
            string name;
            string weight;
            string region;
            string breed;
            string foodType;
            int quantity;
            for (int i = 0; i < lines.Length-1; i+=2)
            {
                string[] words = lines[i].Split(' ');
                animalType = words[0];
                name = words[1];
                weight = words[2];
                region = words[3];
                if (animalType == "cat")
                    breed = words[4];
                //Animal animal = new Animal()
                string[] food = lines[i + 1].Split(' ');
                foodType = food[0];
                quantity = int.Parse(food[1]);

                Console.WriteLine($"{animalType} {name} {weight} {region} {foodType} {quantity}");
            }


            Console.ReadKey();
        }
    }
}