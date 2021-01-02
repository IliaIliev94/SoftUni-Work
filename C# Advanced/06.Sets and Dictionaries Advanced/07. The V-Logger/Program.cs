using System;
using System.Linq;
using System.Collections.Generic;


namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> vloggers = new Dictionary<string, List<int>>();
            Dictionary<string, SortedSet<string>> followers = new Dictionary<string, SortedSet<string>>();

            string[] input = Console.ReadLine().Split();

            while(!input[0].Equals("Statistics"))
            {
                if(input[1].Equals("joined"))
                {
                    string vloggerName = input[0];
                    if(!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new List<int> { 0, 0 });
                        followers.Add(vloggerName, new SortedSet<string> { });
                    }
                }
                else
                {
                    string followed = input[2];
                    string follower = input[0];
                    if(followed != follower)
                    {
                        if (vloggers.ContainsKey(followed) && vloggers.ContainsKey(follower))
                        {
                            if (!followers[followed].Contains(follower))
                            {
                                vloggers[follower][1]++;
                                vloggers[followed][0]++;
                                followers[followed].Add(follower);
                            }
                        }
                    }
                    
                }
                input = Console.ReadLine().Split();
            }
            vloggers = vloggers.OrderByDescending(x => x.Value[0])
                       .ThenBy(x => x.Value[1]).
                       ToDictionary(x => x.Key, x => x.Value);

            int count = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            foreach (var item in vloggers)
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");
                if(count == 1)
                {
                    foreach(var vlogger in followers)
                    {
                        if(vlogger.Key == item.Key)
                        {
                            foreach(var follower in vlogger.Value)
                            {
                                Console.WriteLine($"*  {follower}");
                            }
                        }
                    }
                }
                count++;
            }
        }
    }
}
