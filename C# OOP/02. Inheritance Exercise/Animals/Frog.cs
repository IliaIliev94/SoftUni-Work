using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Frog : Animal
    {
        public override string AnimalType => "Frog";
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
