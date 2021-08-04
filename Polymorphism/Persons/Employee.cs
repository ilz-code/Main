using System;

namespace Persons
{
    class Employee: Person
    {
        string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id; 
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" Job title: {JobTitle}");
        }
    }
}
