using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace _07._Print_All_Minion_Names
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions";
        static void Main(string[] args)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var minions = GetMinions(connection, "SELECT TOP(11) Name FROM Minions");
                PrintMinions(minions);
                connection.Close();
            }
            
        }

        static List<string> GetMinions(SqlConnection connection, string commandText)
        {
            var minions = new List<string>();

            var command = new SqlCommand(commandText, connection);

            using(var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    minions.Add((string)reader["Name"]);
                }
            }

            return minions;
        }

        static void PrintMinions(List<string> minions)
        {
            var middle = (int)Math.Floor(minions.Count / 2.0);
            for (int i = 0; i < middle; i++)
            {
                Console.WriteLine(minions[i]);
                Console.WriteLine(minions[minions.Count - 1 - i]);
            }
            if (minions.Count % 2 != 0)
            {
                Console.WriteLine(minions[middle]);
            }
        }
    }
}
