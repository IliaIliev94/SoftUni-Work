using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Oldest_Family_Member
{
    class Family
    {
        public Family()
        {
            people = new List<Person>();
        }
        public List<Person> people { get; set; }

        public void AddMember(Person Person)
        {
            people.Add(Person);
        }

        public Person GetOldestMember()
        {
            people.Sort((x, y) => x.Age.CompareTo(y.Age));
            return people[0];
        }
    }
}
