using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while(!command.Equals("course start"))
            {
                string[] commands = command.Split(':');

                if (commands[0].Equals("Add"))
                {
                    courses.Add(commands[1]);
                }
                else if (commands[0].Equals("Insert"))
                {
                    if (!courses.Contains(commands[1]))
                    {
                        int index = int.Parse(commands[2]);
                        courses.Insert(index, commands[1]);
                    }
                }
                else if (commands[0].Equals("Remove"))
                {
                    courses.Remove(commands[1]);
                    courses.Remove(commands[1] + "-Exercise");
                }
                else if (commands[0].Equals("Swap"))
                {
                    if (courses.Contains(commands[1]) && courses.Contains(commands[2]))
                    {
                        
                        int index1 = courses.FindIndex(s => s == commands[1]);
                        int index2 = courses.FindIndex(s => s == commands[2]);
                        string temp = courses[index2];
                        courses[index2] = courses[index1];
                        courses[index1] = temp;
                        if (courses.Contains(commands[1] + "-Exercise")) 
                        {
                            string exercise = commands[1] + "-Exercise";
                            courses.Remove(commands[1] + "-Exercise");
                            courses.Insert(index2 + 1, exercise);
                            
                        }
                        if (courses.Contains(commands[2] + "-Exercise"))
                        {
                            string exercise = commands[2] + "-Exercise";
                            courses.Remove(commands[2] + "-Exercise");
                            courses.Insert(index1 + 1, exercise);
                        }
                    }
                }
                else
                {
                    string lesson = commands[1];
                    if (courses.Contains(lesson))
                    {
                        int index = courses.FindIndex(lesson => lesson == commands[1]);
                        if (!courses.Contains(lesson + "-Exercise"))
                        {
                            courses.Insert(index + 1, lesson + "-Exercise");
                        }
                    }
                    else
                    {
                        courses.Add(lesson);
                        courses.Add(lesson + "-Exercise");
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0, j = 1; i < courses.Count; i++, j++)
            {
                Console.WriteLine($"{j}.{courses[i]}");
            }
        }
    }
}
