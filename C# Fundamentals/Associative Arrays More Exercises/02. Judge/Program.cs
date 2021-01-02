using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userResults = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalUserPoints = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while(!command.Equals("no more time"))
            {
                string[] info = command.Split(" -> ");
                string username = info[0];
                string contest = info[1];
                int points = int.Parse(info[2]);
                bool addPoints = true;
                if (userResults.ContainsKey(contest))
                {
                    if (!userResults[contest].ContainsKey(username))
                    {
                        userResults[contest].Add(username, points);
                    }
                    else
                    {
                        if (points > userResults[contest][username])
                        {
                            int temp = points - userResults[contest][username];
                            userResults[contest][username] = points;
                            points = temp;
                        }
                        else
                        {
                            addPoints = false;
                        }
                    }
                }
                else
                {
                    Dictionary<string, int> values = new Dictionary<string, int>();
                    values.Add(username, points);
                    userResults.Add(contest, values);
                }
                if (addPoints)
                {
                    if (totalUserPoints.ContainsKey(username))
                    {
                        totalUserPoints[username] += points;
                    }
                    else
                    {
                        totalUserPoints.Add(username, points);
                    }
                }
                command = Console.ReadLine();
            }

            foreach(var item in userResults)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int counter = 1;
                Dictionary<string, int> temp = item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                foreach (var user in temp)
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }
            totalUserPoints = totalUserPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Individual standings:");
            int i = 1;
            foreach(var item in totalUserPoints)
            {
                Console.WriteLine($"{i}. {item.Key} -> {item.Value}");
                i++;
            }
        }
    }
}
