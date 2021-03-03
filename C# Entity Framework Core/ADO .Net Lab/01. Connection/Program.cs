using System;
using Microsoft.Data.SqlClient;

namespace _01._Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.;Integrated Security=true;Database=SoftUni";
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = new SqlCommand("SELECT d.Name, COUNT(*) AS EmployeesCount " +
                    "FROM Employees e " +
                    "INNER JOIN Departments d " +
                    "ON e.DepartmentId = d.DepartmentId " +
                    "GROUP BY d.Name " +
                    "ORDER BY EmployeesCount DESC", connection);
                using (var reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Name"]} => {reader["EmployeesCount"]}");
                    }
                }
                query.ExecuteReader();
                connection.Close();
            }
        }
    }
}
