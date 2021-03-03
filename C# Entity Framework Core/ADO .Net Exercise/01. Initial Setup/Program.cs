using System;
using Microsoft.Data.SqlClient;

namespace _01._Initial_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the table creation and insertion statements from the functions below
            string[] tableCommands = GetCreateTableStatements();
            string[] insertCommands = GetInsertCommands();

            // Setup the initial connection string to create 'Minions' database
            var connectionString = "Server=.;Integrated Security=true;";

            // Create the database minions
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                CreateEntity(connection, "CREATE DATABASE Minions");
                connection.Close();
            }

            // Execute all of the create and insert statements
            connectionString += "Database=Minions";
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                RunCommands(connection, tableCommands, insertCommands);
                connection.Close();
            } 
        }

        static void CreateEntity(SqlConnection connection, string commandText)
        {
            var command = new SqlCommand(commandText, connection);
            command.ExecuteNonQuery();
        }

        static void RunCommands(SqlConnection connection, string[] tableCommands, string[] insertCommands)
        {
            foreach (var command in tableCommands)
            {
                CreateEntity(connection, command);
            }
            foreach (var command in insertCommands)
            {
                CreateEntity(connection, command);
            }
        }

        static string[] GetCreateTableStatements()
        {
            return new string[]
            {
                "CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY(1, 1), Name VARCHAR(60) NOT NULL)",
                "CREATE TABLE Towns (Id INT PRIMARY KEY IDENTITY(1, 1), Name VARCHAR(60) NOT NULL, CountryCode INT FOREIGN KEY REFERENCES Countries(Id))",
                "CREATE TABLE Minions (Id INT PRIMARY KEY IDENTITY(1, 1), Name VARCHAR(60) NOT NULL, Age INT NOT NULL, TownId INT FOREIGN KEY REFERENCES Towns(Id))",
                "CREATE TABLE EvilnessFactors (Id INT PRIMARY KEY IDENTITY(1, 1), Name VARCHAR(60) NOT NULL)",
                "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY(1, 1), Name VARCHAR(60) NOT NULL, EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))",
                "CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY REFERENCES Minions(Id) NOT NULL, VillainId INT FOREIGN KEY REFERENCES Villains(Id) NOT NULL, CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))"
            };
        }

        static string[] GetInsertCommands()
        {
            return new string[]
            {
                "INSERT INTO Countries (Name) VALUES ('Bulgaria'), ('France'), ('USA'), ('Britain'), ('Japan')",
                "INSERT INTO Towns (Name, CountryCode) VALUES ('Sofia', 1), ('Varna', 1), ('London', 4), ('New York', 3), ('Tokyo', 5)",
                "INSERT INTO Minions (Name, Age, TownId) VALUES ('Pesho', 20, 1), ('Stoyan', 18, 2), ('John', 26, 3), ('Nanami', 30, 5), ('Stamat', 24, 4)",
                "INSERT INTO EvilnessFactors (Name) VALUES ('Neutral'), ('Slightly Evil'), ('Evil'), ('Very Evil'), ('Extremely Evil')",
                "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Pesho', 3), ('Stamat', 5), ('Stoyan', 1), ('Ivan', 2), ('Simon', 4)",
                "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (1, 1), (5, 2), (3, 4), (5, 5), (2, 3)"
            };
        }
    }
}
