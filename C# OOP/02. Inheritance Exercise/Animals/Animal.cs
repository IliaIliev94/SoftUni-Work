using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {

        public virtual string AnimalType { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value != "" && value != " ")
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Invalid input!");
                }
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentNullException("Invalid input!");
                }
            }
        }

        private string gender;
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if(value != "" && value != " ")
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentNullException("Invalid input!");
                }
            }
        }

        public Animal(string name, int age)
        {

            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, string gender) : this(name, age)
        {
            this.Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return "Invalid input";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(AnimalType);
            result.Append($"{this.Name} {this.Age} {this.Gender}");
            return result.ToString();
        }
    }
}
