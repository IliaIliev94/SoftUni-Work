using Microsoft.Data.SqlClient;
using System;

namespace _02._SQL_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var connectionString = "Server=.\\SQLEXPRESS;Integrated Security=true;Database=Minions";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", 
                    connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                var UsersCount = (int)command.ExecuteScalar();
                if(UsersCount > 0)
                {
                    Console.WriteLine($"Welcome back, {username}");
                }
                else
                {
                    Console.WriteLine($"There is no such user. :(");
                }
                connection.Close();
            }
        }
    }
}
