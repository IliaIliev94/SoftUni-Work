using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                people.Add(new Person(name, age));
            }

            List<Person> peopleOlderThanThirty = new List<Person>();

            foreach(var person in people)
            {
                if(person.Age > 30)
                {
                    peopleOlderThanThirty.Add(person);
                }
            }
            peopleOlderThanThirty.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach(var person in peopleOlderThanThirty)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
