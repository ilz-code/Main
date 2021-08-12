using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class PhoneBook
    {
        public static SortedDictionary<string, string> phones = new SortedDictionary<string, string>();

        public static string Finder(string name)
        {
            try
            {
                return phones[name];
            }
            catch (KeyNotFoundException)
            {
                return $"Name {name} is not found.";
            }
        }

        public static string Adder(string name, string number)
        {
            try
            {
                phones.Add(name, number);
                return "Number added.";
            }
            catch (ArgumentException)
            {
                return $"Name {name} already exists.";
            }
        }
    }
}
