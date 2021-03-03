using System;
using Microsoft.Data.SqlClient;

namespace _09._Increase_Age_Stored_Procedure
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions";
        static void Main(string[] args)
        {
            int minionId = int.Parse(Console.ReadLine());
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                ExecuteNonQuery(connection, "EXECUTE usp_GetOlder @MinionId", minionId, "MinionId");
                Console.WriteLine(GetMinionData(connection, "SELECT Name, Age FROM Minions WHERE Id = @MinionId", minionId, "MinionId"));
                connection.Close();
            }
        }

        static object ExecuteScalar(SqlConnection connection, string commandText, int parameter = -1, string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection);
            if (parameter != -1 && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            return command.ExecuteScalar();
        }

        static void ExecuteNonQuery(SqlConnection connection, string commandText, int parameter = -1, string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection);
            if (parameter != -1 && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            command.ExecuteNonQuery();
        }

        static string GetMinionData(SqlConnection connection, string commandText, int parameter = -1, string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection);

            if (parameter != -1 && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }

            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                return $"{reader["Name"]} - {reader["Age"]} years old";
            }
        }

    }
}
