using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string Name, string ID, int Age)
        {
            this.Name = Name;
            this.ID = ID;
            this.Age = Age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


    }
}
