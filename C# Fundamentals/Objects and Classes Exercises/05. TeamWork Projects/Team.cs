using System;
using System.Collections.Generic;
using System.Text;

namespace _05._TeamWork_Projects
{
    class Team
    {
        public Team(string Name, string Creater)
        {
            Members = new List<string>();
            this.Name = Name;
            this.Creater = Creater;
        }
        public string Name { get; set; }
        public string Creater { get; set; }

        public List<string> Members { get; set; }

        public void Add(String Name)
        {
            this.Members.Add(Name);
        }

        
    }
}
