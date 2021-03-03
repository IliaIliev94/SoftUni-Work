using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace _09._Employee_147
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();

            Console.WriteLine(GetEmployee147(dbContext));
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employee = context.Employees.Include(em => em.EmployeesProjects).ThenInclude(em => em.Project).FirstOrDefault(em => em.EmployeeId == 147);

            result.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            var projectsOrderedByName = employee.EmployeesProjects.OrderBy(ep => ep.Project.Name).ToList();

            foreach (var employeeProject in projectsOrderedByName)
            {
                result.AppendLine(employeeProject.Project.Name);
            }

            return result.ToString().TrimEnd();
        }
    }
}
