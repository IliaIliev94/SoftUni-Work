using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> initialContestInformation = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> fullContestInformation = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while(!command.Equals("end of contests"))
            {
                string[] contestInfo = command.Split(':');
                string contest = contestInfo[0];
                string password = contestInfo[1];
                initialContestInformation.Add(contest, password);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(!command.Equals("end of submissions"))
            {
                string[] contestInfo = command.Split("=>");
                string contest = contestInfo[0];
                string password = contestInfo[1];
                string username = contestInfo[2];
                int points = int.Parse(contestInfo[3]);

                if (initialContestInformation.ContainsKey(contest) && initialContestInformation[contest] == password)
                {
                    if (!fullContestInformation.ContainsKey(username))
                    {
                        Dictionary<string, int> userInfo = new Dictionary<string, int>();
                        userInfo.Add(contest, points);
                        fullContestInformation.Add(username, userInfo);
                    }
                    else
                    {
                        if (fullContestInformation[username].ContainsKey(contest))
                        {
                            if (points > fullContestInformation[username][contest])
                            {
                                fullContestInformation[username][contest] = points;
                            }
                            

                        }
                        else
                        {
                            fullContestInformation[username].Add(contest, points);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            fullContestInformation = fullContestInformation.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string name = "";
            int maxPoints = 0;
            foreach(var item in fullContestInformation)
            {
                int studentPoints = 0;
                foreach (var contestInfo in item.Value)
                {

                    studentPoints += contestInfo.Value;
                }
                if (studentPoints > maxPoints)
                {
                    name = item.Key;
                    maxPoints = studentPoints;
                }
            }
            Console.WriteLine($"Best candidate is {name} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in fullContestInformation)
            {
                Console.WriteLine(item.Key);
                Dictionary<string, int> mini = item.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var contestInfo in mini)
                {
                    Console.WriteLine($"#  {contestInfo.Key} -> {contestInfo.Value}");
                }
            }
        }
    }
}
