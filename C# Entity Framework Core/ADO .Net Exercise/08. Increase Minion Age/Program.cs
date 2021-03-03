using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace _08._Increase_Minion_Age
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions";
        static void Main(string[] args)
        {
            int[] minions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                ExecuteNonQuery(connection, $"UPDATE Minions SET Age += 1 WHERE Id IN ({string.Join(", ", minions)})");
                ExecuteNonQuery(connection, $"UPDATE Minions SET Name = UPPER(LEFT(Name, 1)) + RIGHT(Name, LEN(Name) - 1) WHERE Id IN ({string.Join(", ", minions)})");

                var result = ExecuteReader(connection, "SELECT Name, Age FROM Minions", "Name", "Age");

                foreach(var minion in result)
                {
                    Console.WriteLine(minion);
                }
                connection.Close();
            }
            
        }

        static void ExecuteNonQuery(SqlConnection connection, string commandText, string parameter = "", string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection);
            if (parameter != "" && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            command.ExecuteNonQuery();
        }

        static List<string> ExecuteReader(SqlConnection connection, string commandText, string key, string value)
        {
            var result = new List<string>();
            var command = new SqlCommand(commandText, connection);
            

            using(var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    result.Add($"{(string)reader[key]} {(int)reader[value]}");
                }
            }
            return result;
        }
    }
}
