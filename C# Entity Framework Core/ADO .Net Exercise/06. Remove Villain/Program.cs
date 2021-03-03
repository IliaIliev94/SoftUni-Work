using System;
using Microsoft.Data.SqlClient;

namespace _06._Remove_Villain
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions;";
        static void Main(string[] args)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction("Transacton");

                try
                {
                    // Get the villain id
                    var villainId = int.Parse(Console.ReadLine());

                    // Check if such a villain exists
                    var villainName = ExecuteScalar(connection, "SELECT Name FROM Villains WHERE Id = @VillainId", transaction, villainId, "VillainId");

                    if (villainName == null)
                    {
                        Console.WriteLine("No such villain was found.");
                        return;
                    }

                    villainName = villainName.ToString();

                    // Delete all rows in the MinionsVillains table which have that villainId

                    var minionsFreed = ExecuteNonQuery(connection, "DELETE FROM MinionsVillains WHERE VillainId = @VillainId", transaction, villainId, "VillainId");

                    // Delete the villain from the database

                    var villainIsDeleted = ExecuteNonQuery(connection, "DELETE FROM Villains WHERE Id = @VillainId", transaction, villainId, "VillainId");

                    // If the villain was successfully deleted print the messages.

                    if (villainIsDeleted == 1)
                    {
                        Console.WriteLine($"{villainName} was deleted.");
                        Console.WriteLine($"{minionsFreed} minions were released.");
                        transaction.Commit();
                        return;
                    }

                    throw new Exception();
                }
               catch
                {
                    transaction.Rollback();
                }

                connection.Close();
            }

        }

        static object ExecuteScalar(SqlConnection connection, string commandText, SqlTransaction transaction, int parameter = -1, string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection, transaction);
            if (parameter != -1 && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            return command.ExecuteScalar();
        }

        static int ExecuteNonQuery(SqlConnection connection, string commandText, SqlTransaction transaction, int parameter = -1, string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection, transaction);
            if (parameter != -1 && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            return command.ExecuteNonQuery();
        }
    }
}
