using P03._Database_Before.Contracts;
namespace P03._Database
{
    public class Courses
    {
        private IData database;

        public Courses(IData data)
        {
            database = data;
        }
        public void PrintAll()
        {
            var courses = database.CourseNames();

            //print courses
        }

        public void PrintIds()
        {
            var courseIds = database.CourseIds();

            //print course ids
        }

        public void PrintById(int id)
        {
            var course = database.GetCourseById(id);

            // print course
        }

        public void Search(string substring)
        {
            var courses = database.Search(substring);

            // print courses
        }
    }
}
