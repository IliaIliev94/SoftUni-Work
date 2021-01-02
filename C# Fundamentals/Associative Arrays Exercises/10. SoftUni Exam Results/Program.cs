using System;
using System.Linq;
using System.Collections.Generic;
namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while(!command.Equals("exam finished"))
            {
                string[] studentInfo = command.Split("-");
                string student = studentInfo[0];

                if (studentInfo[1] == "banned")
                {
                    if (result.ContainsKey(student))
                    {
                        result.Remove(student);
                    }
                }
                else
                {
                    string language = studentInfo[1];
                    string points = studentInfo[2];
                    if (!result.ContainsKey(student))
                    {
                        result.Add(student, new List<string> { language, points });
                    }
                    else
                    {
                        if (int.Parse(points) > int.Parse(result[student][1]))
                        {
                            result.Remove(student);
                            result.Add(student, new List<string> { language, points });
                        }
                    }
                    if (submissions.ContainsKey(language))
                    {
                        submissions[language]++;
                    }
                    else
                    {
                        submissions.Add(language, 1);
                    }
                }
                command = Console.ReadLine();
            }
            result = result.OrderByDescending(x => int.Parse(x.Value[1])).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Results:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} | {item.Value[1]}");
            }
            submissions = submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Submissions:");
            foreach (var item in submissions)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
