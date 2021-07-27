using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs
{
    public class Dog
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public Dog Mother { get; set; }
        public Dog Father { get; set; }

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;            
        }
          
        public string FathersName()
        {
            string fn = Father.Name == null ? "Unknown" : Father.Name;
            return fn;
        }

        public bool HasSameMotherAs(Dog dog)
        {
            this.Mother == dog.Mother;
        }

    }
}
