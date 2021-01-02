using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public override string AnimalType => "Kitten";

        public Kitten(string name, int age) : base(name, age)
        {
            this.Gender = "Female";
        }
        public Kitten(string name, int age, string gender) : base(name, age)
        {
            this.Gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

    }
}
