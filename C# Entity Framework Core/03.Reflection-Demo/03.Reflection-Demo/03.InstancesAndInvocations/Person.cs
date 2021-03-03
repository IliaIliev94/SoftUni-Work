namespace InstancesAndInvocations
{
    using System;

    public class Person : IPerson
    {
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected Person()
        {
        }

        public string Name { get; private set; }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age value, cannot be below zero!");
                }

                this.age = value;
            }
        }

        public string Eat(string food)
        {
            return $"Mm so yummy {food}";
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Age} years old.";
        }
    }
}
