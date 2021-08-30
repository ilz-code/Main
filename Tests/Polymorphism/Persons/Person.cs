using System;

namespace Persons
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        public Person()
        { }
               
        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n First name: {FirstName}\n Last name: {LastName} \n Address: {Address} \n ID: {Id}");
        }
    }
}
