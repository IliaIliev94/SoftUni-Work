using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();
            while(!command.Equals("End"))
            {
                string[] personInfo = command.Split();
                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);
                people.Add(new Person(name, ID, age));
                command = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].Name} with ID: {people[i].ID} is {people[i].Age} years old.");
            }
        }
    }

}
