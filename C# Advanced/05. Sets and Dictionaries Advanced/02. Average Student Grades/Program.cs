using System;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for(int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine().Split();
                string student = studentData[0];
                double grade = double.Parse(studentData[1]);
                if(studentGrades.ContainsKey(student))
                {
                    studentGrades[studentData[0]].Add(grade);
                }
                else
                {
                    studentGrades.Add(student, new List<double> { grade });
                }
            }
            foreach(var item in studentGrades)
            {
                Console.WriteLine($"{item.Key} -> {PrintGrades(item.Value)} (avg: {Average(item.Value).ToString("0.00")})");
            }
        }

        static string PrintGrades(List<double> grades)
        {
            string result = "";
            for(int i = 0; i < grades.Count; i++)
            {
                if(i == 0)
                {
                    result += grades[i].ToString("0.00");
                }
                else
                {
                    result += " " + grades[i].ToString("0.00");
                }
            }
            return result;
        }
        static double Average(List<double> grades)
        {
            double average = 0;
            foreach(double grade in grades)
            {
                average += grade;
            }

            return average / grades.Count;
        }
    }
}
