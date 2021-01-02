using System;
using System.Collections.Generic;
namespace _05._Football_Team_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string command = Console.ReadLine();
            while(!command.Equals("END"))
            {
                try
                {
                    string[] data = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                    if (data[0].Equals("Team"))
                    {
                        teams.Add(new Team(data[1]));
                    }
                    else if (data[0].Equals("Add"))
                    {
                        int index = teams.FindIndex(x => x.Name == data[1]);
                        if (index != -1)
                        {
                            string name = data[2];
                            int endurance = int.Parse(data[3]);
                            int sprint = int.Parse(data[4]);
                            int dribble = int.Parse(data[5]);
                            int passing = int.Parse(data[6]);
                            int shooting = int.Parse(data[7]);
                            teams[index].AddPlayer(new Player(name, endurance, sprint, dribble, passing, shooting));
                        }
                        else
                        {
                            throw new ArgumentException($"Team {data[1]} does not exist.");
                        }
                    }
                    else if (data[0].Equals("Remove"))
                    {
                        int index = teams.FindIndex(x => x.Name == data[1]);
                        teams[index].RemovePlayer(data[2]);
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.Name == data[1]);
                        if (index != -1)
                        {
                            Console.WriteLine(teams[index]);
                        }
                        else
                        {
                            throw new ArgumentException($"Team {data[1]} does not exist.");
                        }
                    }
                }
                catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}
