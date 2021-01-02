using System;
using System.Linq;
using System.Collections.Generic;
namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for(int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split();
                people.Add(new Person(data[0], data[1], int.Parse(data[2])));
            }

            people = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
