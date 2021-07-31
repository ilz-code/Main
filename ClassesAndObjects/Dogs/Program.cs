using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.Mother = lady;
            max.Father = rocky;
            coco.Mother = molly;
            coco.Father = buster;
            rocky.Mother = molly;
            rocky.Father = sam;
            buster.Mother = lady;
            buster.Father = sparky;

            Console.WriteLine(coco.FathersName());
            Console.WriteLine(sparky.FathersName());
            Console.WriteLine("Coco and Rocky has the same mother: " + coco.HasSameMotherAs(rocky));

            Console.ReadKey();
        }
    }
}
