using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    public class Pet : IBirthed
    {
        public string Name { get; private set; }
        public string Birthdate { get; private set; }
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.Birthdate = birthDate;
        }

        public bool EndsWith(string id)
        {
            return this.Birthdate.Substring(this.Birthdate.Length - id.Length, id.Length).Equals(id);
        }
    }
}
