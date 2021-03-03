using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _10._Departments_with_More_Than_5_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine(GetDepartmentsWithMoreThan5Employees(dbContext));
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var result = new StringBuilder();

            var departmentsWithEmployees = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    Employees = d.Employees.Select(e => new { e.FirstName, e.LastName, e.JobTitle })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList()
                })
                .ToList();

            foreach(var department in departmentsWithEmployees)
            {
                result.AppendLine($"{department.DepartmentName} - {department.ManagerFirstName} {department.ManagerLastName}");

                foreach(var employee in department.Employees)
                {
                    result.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
