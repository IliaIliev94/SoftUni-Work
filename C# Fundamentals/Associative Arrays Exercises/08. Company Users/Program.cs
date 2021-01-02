using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] information = command.Split(" -> ");
                string company = information[0];
                string employeeID = information[1];

                if (employees.ContainsKey(company))
                {
                    if (!employees[company].Contains(employeeID))
                    {
                        employees[company].Add(employeeID);
                    }
                }
                else
                {
                    employees.Add(company, new List<string> { employeeID });
                }
                command = Console.ReadLine();
            }
            employees = employees.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in employees)
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
