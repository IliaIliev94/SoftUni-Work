using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace _05._Change_Town_Names_Casing
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions";
        static void Main(string[] args)
        {
            var countryName = Console.ReadLine();

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var country = ExecuteScalar(connection, "SELECT TOP(1) Id FROM Countries WHERE Name = @CountryName", countryName, "CountryName");

                if(country == null)
                {
                    Console.WriteLine("No town names were affected.");
                    return;
                }

                var countriesList = GetCountries(connection, $"SELECT Name FROM Towns WHERE CountryCode = {(int)country} AND Name != UPPER(Name) COLLATE Latin1_General_BIN");

                ExecuteNonQuery(connection, $"UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = {(int)country}");

                if(countriesList.Count < 1)
                {
                    Console.WriteLine("No town names were affected.");
                    return;
                }
                Console.WriteLine($"{countriesList.Count} towns names were affected.");
                Console.WriteLine($"[{string.Join(", ", countriesList)}]");
                connection.Close();
            }

            
        }

        static object ExecuteScalar(SqlConnection connection, string commandText, string parameter = "", string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection);
            if (parameter != "" && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            return command.ExecuteScalar();
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

        static List<string> GetCountries(SqlConnection connection, string commandText)
        {
            var command = new SqlCommand(commandText, connection);
            List<string> towns = new List<string>();
            using(var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    towns.Add(reader["Name"].ToString().ToUpper());
                }
            }
            return towns;
        }
    }
}
