using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Person
{
    public class Child : Person
    {
        
        public int Age
        {
            set
            {
                if(value > 15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.Age = value;
            }
        }

        public Child(string name, int age) : base(name, age)
        {

        }
    }
}
