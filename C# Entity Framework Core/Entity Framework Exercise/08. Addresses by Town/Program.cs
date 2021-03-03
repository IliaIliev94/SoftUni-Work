using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _08._Addresses_by_Town
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();

            Console.WriteLine(GetAddressesByTown(dbContext));
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var result = new StringBuilder();

            var addresses = context.Addresses
                .Select(a => new
                {
                    EmployeesCount = a.Employees.Count(),
                    TownName = a.Town.Name,
                    AddressText = a.AddressText
                })
                .OrderByDescending(a => a.EmployeesCount)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .ToList();

            foreach(var address in addresses)
            {
                result.AppendLine($"{address.AddressText}, {address.TownName} - {address.EmployeesCount} employees");
            }

            return result.ToString().TrimEnd();
        }
    }
}
