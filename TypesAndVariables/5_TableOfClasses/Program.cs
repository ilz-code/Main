using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TableOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "Calculus", "Biology", "Geography", "Music", "Sport", "Literature", "Grammar", "French" };
            string[] teachers = { "Bērziņš", "Kārkliņa", "Kļaviņa", "Samanta", "Jānis Lūsis", "Rainis", "Aspazija", "Mademoiselle" };
            Console.WriteLine();
            string dashes = new string('-', 50);
            Console.WriteLine(" +" + dashes + "+");

            int count = courses.Length;
            string spacesCourses;
            string spacesTeachers;
            for (int i=0; i < count; i++)
            {
                spacesCourses = new string(' ', 26 - courses[i].Length);
                spacesTeachers = new string(' ', 17 - teachers[i].Length);
                Console.WriteLine($" | {i} | {courses[i]}"+spacesCourses+"| "+teachers[i]+spacesTeachers +"|");
            }
            Console.WriteLine(" +" + dashes + "+");
            Console.ReadKey();
        }
    }
}
