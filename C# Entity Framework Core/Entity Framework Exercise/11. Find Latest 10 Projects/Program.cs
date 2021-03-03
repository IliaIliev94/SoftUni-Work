using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _11._Find_Latest_10_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            Console.WriteLine(GetLatestProjects(dbContext));
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var result = new StringBuilder();
            var projects = context.Projects.OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name);

            foreach(var project in projects)
            {
                result.AppendLine(project.Name + Environment.NewLine + project.Description +
                    Environment.NewLine + project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
            }

            return result.ToString().TrimEnd();
        }
    }
}
