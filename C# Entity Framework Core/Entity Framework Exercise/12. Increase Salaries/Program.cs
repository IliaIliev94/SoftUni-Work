using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._Increase_Salaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine(IncreaseSalaries(dbContext));
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            List<string> departmentsToQuery = new List<string>()
            {
                "Engineering",
                "Tool Design",
                "Marketing",
                "Information Services"
            };
            List<Employee> employees = context.Employees.Where(em => departmentsToQuery.Contains(em.Department.Name))
                .OrderBy(em => em.FirstName)
                .ThenBy(em => em.LastName)
                .ToList();

            foreach(Employee employee in employees)
            {
                employee.Salary = Math.Floor(employee.Salary * 1.12m);
            }

            context.SaveChanges();

            foreach(Employee employee in employees)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} ({employee.Salary.ToString("0.00")})");
            }

            return result.ToString().TrimEnd();
        }
    }
}
