using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Students
{
    class Student
    {
        public Student(string FirstName, string LastName, double Grade)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Grade = Grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
