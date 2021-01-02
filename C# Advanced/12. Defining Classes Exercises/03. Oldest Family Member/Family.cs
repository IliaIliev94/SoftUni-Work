using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People {get; set;}

        public Family()
        {
            this.People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
