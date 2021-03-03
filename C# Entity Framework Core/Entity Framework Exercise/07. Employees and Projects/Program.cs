using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _07._Employees_and_Projects
{
    class Program
    {
        const string dateTimeFormat = "M/d/yyyy h:mm:ss tt";
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            Console.WriteLine(GetEmployeesInPeriod(dbContext));
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var result = new StringBuilder();
            var employeesWithProjects = context.Employees
                .Select(em => new
                {
                    em.FirstName,
                    em.LastName,
                    ManagerFirstName = em.Manager.FirstName,
                    ManagerLastName = em.Manager.LastName,
                    Projects = em.EmployeesProjects.Select(ep => new { ep.Project.Name, ep.Project.StartDate, ep.Project.EndDate })
                })
                .Where(em => em.Projects.Any(pr => pr.StartDate.Year >= 2001 && pr.StartDate.Year <= 2003))
                .Take(10)
                .ToList();

            foreach(var employee in employeesWithProjects)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                foreach (var project in employee.Projects)
                {
                    var finished = project.EndDate == null ? "not finished" : project.EndDate.Value.ToString(dateTimeFormat);
                    result.AppendLine($"--{project.Name} - {project.StartDate.ToString(dateTimeFormat)} - {finished}");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
