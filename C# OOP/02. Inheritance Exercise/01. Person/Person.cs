using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Person
{
    public class Person
    {
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive number!");
                }
                else
                {
                    age = value;
                }
                
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return result.ToString();
        }
    }
}
