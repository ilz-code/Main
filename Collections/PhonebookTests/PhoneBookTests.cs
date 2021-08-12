using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Phonebook;

namespace PhonebookTests
{
    [TestClass]
    public class PhoneBookTests
    {
        string name;
        string number;
        SortedDictionary<string, string> phones = new SortedDictionary<string, string>() {};
       
        [TestMethod]
        public void AddNum_name_DictObj()
        {
            PhoneBook.Adder("Ilze", "26362347");
            PhoneBook.Adder("Arvids", "26058324");
            PhoneBook.Adder("Oskars", "27177941");
            PhoneBook.Adder("Ilze", "26362347");
            int result = PhoneBook.phones.Count;
            int expect = 3;
            Assert.AreEqual(expect, result);
        }

        [DataTestMethod]
        [DataRow("Ilze", "26362347")]
        [DataRow("Janis", "Name Janis is not found.")]
        public void FindNum_name_number(string name, string number)
        {
            string result = Phonebook.PhoneBook.Finder(name);
            Assert.AreEqual(number, result);
        }
    }
}
