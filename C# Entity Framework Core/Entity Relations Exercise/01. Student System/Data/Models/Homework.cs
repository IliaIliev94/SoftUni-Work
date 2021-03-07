using System;

namespace P01_StudentSystem.Data.Models
{
    public enum HomeworkNames
    {
        Application,
        PDF,
        Zip
    }
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public HomeworkNames ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}