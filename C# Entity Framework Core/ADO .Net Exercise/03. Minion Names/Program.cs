using System;
using Microsoft.Data.SqlClient;

namespace _03._Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var villainId = int.Parse(Console.ReadLine());
            var connectionString = "Server=.;Integrated Security=true;Database=Minions";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get information about the villain (id, name, minionsCount)
                var villainsCountWithId = (int)ReturnValueFromDatabase(connection, "SELECT COUNT(*) FROM Villains WHERE Id = @VillainId", villainId);

                var villainName = (string)ReturnValueFromDatabase(connection, $"SELECT TOP(1) Name FROM Villains WHERE Id = {villainId}");

                var minionsCount = (int)ReturnValueFromDatabase(connection, $"SELECT COUNT(*) FROM MinionsVillains WHERE VillainId = {villainId}");

                // If there is no villain with the given id print a message that there is no such villain
                if (villainsCountWithId < 1)
                {
                    Console.WriteLine($"No villain exists with ID {villainId} exists in the database.");
                    return;
                }

                // If there is print the villain name
                Console.WriteLine($"Villain: {villainName}");

                // If the villain doesn't have villains print no minions
                if(minionsCount < 1)
                {
                    Console.WriteLine("(no minions)");
                    return;
                }

                // If the villain has villains print the information about the minions
                var command = new SqlCommand($"SELECT m.Name, m.Age FROM Minions m INNER JOIN MinionsVillains mv ON m.Id = mv.MinionId WHERE mv.VillainId = {villainId}", connection);
                var minions = command.ExecuteReader();
                for(int i = 1; minions.Read(); i++)
                {
                    Console.WriteLine($"{i}. {minions["Name"]} {minions["Age"]}");
                }

                connection.Close();
            }
        }

        static object ReturnValueFromDatabase(SqlConnection connection, string commandText, int parameterId = -1)
        {
            var command = new SqlCommand(commandText, connection);
            if (parameterId != -1)
            {
                command.Parameters.AddWithValue("@VillainId", parameterId);
            }
           var result = command.ExecuteScalar();
            return result;
        }
    }
}
