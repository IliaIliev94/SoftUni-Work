using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Employees_Full_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            Console.WriteLine(GetEmployeesFullInformation(dbContext));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var result = new StringBuilder();
            var employeeInfo = context.Employees.Select(em => $"{em.FirstName} {em.LastName} {em.MiddleName} {em.JobTitle} {em.Salary.ToString("0.00")}").ToList();
            InsertAllEmployees(result, employeeInfo);
            return result.ToString().TrimEnd();

        }

        public static void InsertAllEmployees(StringBuilder employeesHolder, List<string> employeesList)
        {
            foreach (var employee in employeesList)
            {
                employeesHolder.AppendLine(employee);
            }
        }
    }
}
