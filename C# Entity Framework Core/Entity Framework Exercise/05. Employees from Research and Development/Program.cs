using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _05._Employees_from_Research_and_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();

            Console.WriteLine(GetEmployeesFromResearchAndDevelopment(dbContext));
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = new StringBuilder();

            var employeesFromResearchAndDevelopment = context.Employees
                .Select(em => new { em.FirstName, em.LastName, Department = em.Department.Name, em.Salary })
                .Where(em => em.Department == "Research and Development")
                .OrderBy(em => em.Salary)
                .ThenByDescending(em => em.FirstName)
                .ToList();

            foreach(var employee in employeesFromResearchAndDevelopment)
            {
                employees.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department} - ${employee.Salary.ToString("0.00")}");
            }

            return employees.ToString().TrimEnd();
        }
    }
}
