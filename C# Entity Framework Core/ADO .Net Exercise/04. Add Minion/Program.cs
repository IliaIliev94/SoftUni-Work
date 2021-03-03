using System;
using Microsoft.Data.SqlClient;

namespace _04._Add_Minion
{
    class Program
    {
        const string connectionString = "Server=.;Integrated Security=true;Database=Minions";
        static void Main(string[] args)
        {
            // Get the minion information
            string[] minionInfo = Console.ReadLine().Split(": ")[1].Split(" ");
            string minionName = minionInfo[0];
            int minionAge = int.Parse(minionInfo[1]);
            string minionTown = minionInfo[2];
            // Get the villian information
            string villainName = Console.ReadLine().Split(": ")[1];

            // Initialize the connection
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction("Transaction");

                try
                {
                    // Check if the town is in the database and if it isn't add the town to the database
                    var town = ExecuteScalar(connection, "SELECT TOP(1) Id FROM Towns WHERE Name = @TownName", transaction, minionTown, "TownName");

                    var villain = ExecuteScalar(connection, "SELECT TOP(1) Id FROM Villains WHERE Name = @VillainName",transaction, villainName, "VillainName");



                    if (town == null)
                    {
                        ExecuteNonQuery(connection, "INSERT INTO Towns (Name) VALUES (@TownName)", transaction, minionTown, "TownName");
                        town = ExecuteScalar(connection, "SELECT TOP(1) Id FROM Towns WHERE Name = @TownName",transaction,  minionTown, "TownName");
                        Console.WriteLine($"Town {minionTown} was added to the database.");
                    }


                    // If the villain isn't in the database add it as well with a default evilness factor of evil
                    if (villain == null)
                    {
                        ExecuteNonQuery(connection, "INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@VillainName, 4)", transaction,  villainName, "@VillainName");
                        villain = ExecuteScalar(connection, "SELECT TOP(1) Id FROM Villains WHERE Name = @VillainName", transaction, villainName, "VillainName");
                        Console.WriteLine($"Villain {villainName} was added to the database.");
                    }

                    /* Add the minion to the database and make the minion to be a servant of the villain (by adding a row in the database,
                     by adding a row with the minion Id and villain Id in the MinionsVillains table ) */

                    ExecuteNonQuery(connection, $"INSERT INTO Minions (Name, Age, TownId) VALUES ('{minionName}', {minionAge}, {(int)town})", transaction);
                    var minion = ExecuteScalar(connection, $"SELECT TOP(1) Id FROM Minions WHERE Name = '{minionName}' AND TownId = {(int)town}", transaction);
                    ExecuteNonQuery(connection, $"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES ({(int)minion}, {(int)villain})", transaction);
                    Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    transaction.Rollback();
                    
                }
                connection.Close();
            }
        }

        static object ExecuteScalar(SqlConnection connection, string commandText, SqlTransaction transaction, string parameter = "", string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection, transaction);
            if(parameter != "" && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            return command.ExecuteScalar();
        }

        static void ExecuteNonQuery(SqlConnection connection, string commandText, SqlTransaction transaction, string parameter = "", string parameterName = "")
        {
            var command = new SqlCommand(commandText, connection, transaction);
            if(parameter != "" && parameterName != "")
            {
                command.Parameters.AddWithValue("@" + parameterName, parameter);
            }
            command.ExecuteNonQuery();
        }
    }
}
