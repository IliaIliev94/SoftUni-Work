using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUni.Data;
namespace _04._Employees_with_Salary_Over_50_000
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();

            Console.WriteLine(GetEmployeesWithSalaryOver50000(dbContext));
        }

        public static string GetEmployeesWithSalaryOver50000 (SoftUniContext context)
        {
            var employees = new StringBuilder();

            var employeesWithSalaryOver50000 = context.Employees
                .Select(em => new { em.FirstName, em.Salary })
                .Where(em => em.Salary > 50000)
                .OrderBy(em => em.FirstName)
                .ToList();

            foreach (var employee in employeesWithSalaryOver50000)
            {
                employees.AppendLine($"{employee.FirstName} - {employee.Salary.ToString("0.00")}");
            }

            return employees.ToString().TrimEnd();
        }

    }
}
