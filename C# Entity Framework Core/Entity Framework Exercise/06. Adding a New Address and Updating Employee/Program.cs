using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Adding_a_New_Address_and_Updating_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            Console.WriteLine(AddNewAddressToEmployee(dbContext));

        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var employees = new StringBuilder();

            var employeeWithLastNameNakov = context.Employees.FirstOrDefault(em => em.LastName == "Nakov");

            employeeWithLastNameNakov.Address = CreateAddress("Vitoshka 15", 4);

            context.SaveChanges();

            var employeesSortedByAddress = context.Employees
                .Select(em => new { em.Address.AddressId, AddressText = em.Address.AddressText})
                .OrderByDescending(em => em.AddressId)
                .Take(10).ToList();

            foreach(var employee in employeesSortedByAddress)
            {
                employees.AppendLine(employee.AddressText);
            }

            return employees.ToString().TrimEnd();

        }

        public static Address CreateAddress(string addressName, int townId)
        {
            return new Address() { AddressText = addressName, TownId = townId };
        }
    }
}
