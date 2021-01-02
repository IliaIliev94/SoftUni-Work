using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] newStudent = Console.ReadLine().Split();
                students.Add(new Student(newStudent[0], newStudent[1], double.Parse(newStudent[2])));
            }
            
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].Grade < students[j].Grade)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].FirstName} {students[i].LastName}: {students[i].Grade.ToString("0.00")}");
            }
        }
    }

}
