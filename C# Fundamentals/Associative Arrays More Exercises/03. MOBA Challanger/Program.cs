using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Challanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalPlayerPoints = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while(!command.Equals("Season end"))
            {
                string[] commandType = command.Split();
                if (commandType[1] == "->")
                {
                    string[] info = command.Split(" -> ");
                    string player = info[0];
                    string position = info[1];
                    int skill = int.Parse(info[2]);
                    bool addSkill = true;
                    if (!players.ContainsKey(player))
                    {
                        Dictionary<string, int> newPosition = new Dictionary<string, int>();
                        newPosition.Add(position, skill);
                        players.Add(player, newPosition);
                    }
                    else if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else if (skill > players[player][position])
                    {
                        int temp = skill - players[player][position];
                        players[player][position] = skill;
                        skill = temp;
                    }
                    else
                    {
                        addSkill = false;
                    }
                    if (addSkill)
                    {
                        if(totalPlayerPoints.ContainsKey(player))
                        {
                            totalPlayerPoints[player] += skill;
                        }
                        else
                        {
                            totalPlayerPoints.Add(player, skill);
                        }
                    }
                }
                else
                {
                    string[] info = command.Split(" vs ");
                    string playerOne = info[0];
                    string playerTwo = info[1];

                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        foreach (var item in players[playerOne])
                        {
                            if (players[playerTwo].ContainsKey(item.Key))
                            {
                                if (players[playerOne][item.Key] > players[playerTwo][item.Key])
                                {
                                    players.Remove(playerTwo);
                                    totalPlayerPoints.Remove(playerTwo);
                                    break;
                                }
                                else if (players[playerOne][item.Key] < players[playerTwo][item.Key])
                                {
                                    players.Remove(playerOne);
                                    totalPlayerPoints.Remove(playerOne);
                                    break;
                                }
                            }
                        }
                    }
                }
               
                command = Console.ReadLine();
            }
            totalPlayerPoints = totalPlayerPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in totalPlayerPoints)
            {
                Console.WriteLine($"{item.Key}: {item.Value} skill");
                Dictionary<string, int> temp = players[item.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                foreach (var position in temp)
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
