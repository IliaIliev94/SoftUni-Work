using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SoftUni
{
    public class StartUp
    {
        private const string townNameToDelete = "Seattle";
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine(RemoveTown(dbContext));
        }

        public static string RemoveTown(SoftUniContext context)
        {
            Town town = context.Towns.Include(t => t.Addresses).ThenInclude(a => a.Employees).FirstOrDefault(t => t.Name == townNameToDelete);

            // Get all addresses for the town Seattle
            List<Address> addresses = town.Addresses.ToList();

            // For each address set the address id of all employees living there to null

            foreach (Address address in addresses)
            {
                foreach (Employee employee in address.Employees)
                {
                    employee.AddressId = null;
                }
                // Delete all the addressses from the town
                address.TownId = null;
                context.Addresses.Remove(address);
            }

            town.Addresses = null;

            // Delete the town
            context.Towns.Remove(town);

            // Save the changes to the database
            context.SaveChanges();

            return $"{addresses.Count} addresses in {townNameToDelete} were deleted";
        }
    }
}
