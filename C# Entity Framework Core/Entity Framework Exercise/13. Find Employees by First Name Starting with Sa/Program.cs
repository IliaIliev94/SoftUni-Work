using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._Find_Employees_by_First_Name_Starting_with_Sa
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(dbContext));
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            List<Employee> employees = context.Employees
                .Where(em => em.FirstName.Substring(0, 2).ToLower() == "sa")
                .OrderBy(em => em.FirstName)
                .ThenBy(em => em.LastName)
                .ToList();

            foreach(var employee in employees)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary.ToString("0.00")})");
            }

            return result.ToString().TrimEnd();
        }
    }
}
