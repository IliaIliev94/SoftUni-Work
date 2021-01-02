using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    public class Citizen : ICitizen, IBirthed
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthDate;
        }
        public bool EndsWith(string id)
        {
            return this.Birthdate.Substring(this.Birthdate.Length - id.Length, id.Length).Equals(id);
        }
    }
}
