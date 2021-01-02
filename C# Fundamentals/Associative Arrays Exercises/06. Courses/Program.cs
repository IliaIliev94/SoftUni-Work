using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while(!command.Equals("end"))
            {
                string[] courseInfo = command.Split(" : ");
                string course = courseInfo[0];
                string student = courseInfo[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string> { student });
                }
                else
                {
                    courses[course].Add(student);
                }
                command = Console.ReadLine();
            }
            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach(var item in courses)
            {
                item.Value.Sort((x, y) => x.CompareTo(y));
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
