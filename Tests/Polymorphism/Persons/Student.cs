using System;

namespace Persons
{    
    class Student: Person
    {
        double Gpa { get; set; }

        public Student(string name, string lastName, string address, int id, double gpa) : base(name, lastName, address, id)
        {
            Gpa = gpa;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" GPA = {Gpa}");
        }
    }
}
