using Microsoft.Data.SqlClient;
using System;

namespace _02._Villain_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the connection string to open the database
            var connectionString = "Server=.;Integrated Security=true;Database=Minions";

            // Open the connection
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the command to get all villains with more than 3 minions with their number of minions
                var command = new SqlCommand(@"SELECT v.Name, COUNT(*) AS Minions FROM Villains v 
                    INNER JOIN MinionsVillains mv ON v.Id = mv.VillainId INNER JOIN Minions m ON mv.MinionId = m.Id 
                    GROUP BY v.Name HAVING COUNT(*) > 3 ORDER BY Minions DESC", connection);

                // Print each villain with the number of minions
                using(var villains = command.ExecuteReader())
                {
                    while(villains.Read())
                    {
                        Console.WriteLine($"{villains["Name"]} - {villains["Minions"]}");
                    }
                }
                connection.Close();
            }
        }
    }
}
