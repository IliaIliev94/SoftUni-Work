namespace StudentSystem
{
    using StudentSystem.Entities;
    using System;
    using System.Collections.Generic;

    public class StudentData
    {

        public Dictionary<string, Student> Students { get; private set; } = new Dictionary<string, Student>();

        public void AddStudent(string name, int age, double grade)
        {
            if (!Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Students[name] = student;
            }
        }

        public string GetDetails(string name)
        {
            if (!Students.ContainsKey(name))
            {
                return null;
            }
            var student = Students[name];

            var details = student.ToString();
            return details;
        }
    }

    
}