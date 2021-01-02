using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._TeamWork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeams = Console.ReadLine().Split('-');
                bool isFoundCreater = false;
                bool isFoundTeam = false;
                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[j].Name == newTeams[1])
                    {
                        isFoundTeam = true;
                    }
                    else if (teams[j].Creater == newTeams[0])
                    {
                        isFoundCreater = true;
                    }
                }
                if (isFoundTeam)
                {
                    Console.WriteLine($"Team {newTeams[1]} was already created!");
                }
                else if (isFoundCreater)
                {
                    Console.WriteLine($"{newTeams[0]} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {newTeams[1]} has been created by {newTeams[0]}!");
                    teams.Add(new Team(newTeams[1], newTeams[0]));
                }
                
            }

            string command = Console.ReadLine();

            while(!command.Equals("end of assignment"))
            {
                string[] commands = command.Split("->");
                int teamIndex = teams.FindIndex((x) => x.Name == commands[1]);

                bool isInTeam = false;
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = 0; j  < teams[i].Members.Count; j++)
                    {
                        if (teams[i].Members[j] == commands[0])
                        {
                            isInTeam = true;
                            break;
                        }
                    }
                }
                if (teamIndex == -1)
                {
                    Console.WriteLine($"Team {commands[1]} does not exist!");
                }
                else if (isInTeam || commands[0] == teams[teamIndex].Creater)
                {
                    Console.WriteLine($"Member {commands[0]} cannot join team {commands[1]}!");
                }
                else
                {
                    teams[teamIndex].Add(commands[0]);
                }
                command = Console.ReadLine();
            }
            teams = teams.OrderBy(x => x.Members.Count).ThenByDescending(x => x.Name).ToList();
            List<string> teamsToDisband = new List<string>();
            for (int i = teams.Count - 1; i >= 0; i--)
            {
                if (teams[i].Members.Count == 0)
                {
                    teamsToDisband.Add(teams[i].Name);
                }
                else
                {
                    Console.WriteLine(teams[i].Name);
                    Console.WriteLine($"- {teams[i].Creater}");
                    teams[i].Members = teams[i].Members.OrderBy(x => x).ToList();
                    for (int j = 0; j < teams[i].Members.Count; j++)
                    {
                        Console.WriteLine($"-- {teams[i].Members[j]}");
                    }
                }
                
            }
            teamsToDisband.Sort((x, y) => x.CompareTo(y));
            Console.WriteLine("Teams to disband:");
            for (int i = 0; i < teamsToDisband.Count; i++)
            {
                Console.WriteLine(teamsToDisband[i]);
            }
            
        }

    }

}
