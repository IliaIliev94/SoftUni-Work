using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public override string AnimalType => "Tomcat";

        public Tomcat(string name, int age) : base(name, age)
        {
            this.Gender = "Male";
        }
        public Tomcat(string name, int age, string gender) : base(name, age)
        {
            this.Gender = "Male";
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }

    }
}
