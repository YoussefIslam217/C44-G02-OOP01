using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
}
