using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];
                employees.Add(new Employee(name, salary, department));
                if (!departments.Contains(department))
                {
                    departments.Add(department);
                }
            }

            int departmentIndex = 0;
            double maxSum = double.MinValue;


            for (int i = 0; i < departments.Count; i++)
            {
                double sum = 0;
                int counter = 0;
                for (int j = 0; j < employees.Count; j++)
                {
                    if (employees[j].Department == departments[i])
                    {
                        sum += employees[j].Salary;
                        counter++;
                    }
                }
                sum /= counter;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    departmentIndex = i;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departments[departmentIndex]}");
            List<Employee> largestDepartment = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Department == departments[departmentIndex])
                {
                    largestDepartment.Add(employees[i]);
                }
            }

            largestDepartment.Sort((x, y) => y.Salary.CompareTo(x.Salary));

            for (int i = 0; i < largestDepartment.Count; i++)
            {
                Console.WriteLine($"{largestDepartment[i].Name} {largestDepartment[i].Salary.ToString("0.00")}");
            }
        }
    }

}
