using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
