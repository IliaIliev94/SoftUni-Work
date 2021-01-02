using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
{
    public class Citizen : ICitizen
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public bool EndsWith(string id)
        {
            return this.Id.Substring(this.Id.Length - id.Length, id.Length).Equals(id);
        }
    }
}
