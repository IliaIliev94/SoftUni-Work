using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(student))
                {

                    studentGrades[student].Add(grade);

                }
                else
                {

                    studentGrades.Add(student, new List<double> { grade });

                }
            }
            studentGrades = studentGrades.OrderByDescending(x => (x.Value.Sum() / x.Value.Count)).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in studentGrades)
            {
                double average = item.Value.Sum() / item.Value.Count;
                if (average < 4.50)
                {
                    studentGrades.Remove(item.Key);
                }
            }
            foreach(var item in studentGrades)
            {
                double average = item.Value.Sum() / item.Value.Count;
                Console.WriteLine($"{item.Key} -> {average.ToString("0.00")}");
            }
        }
    }
}
