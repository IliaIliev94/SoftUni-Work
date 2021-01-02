using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while(!command.Equals("Statistics"))
            {
                string[] words = command.Split("->");
                if (words[0].Equals("Add"))
                {
                    string user = words[1];
                    if(emails.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} is already registered");
                    }
                    else
                    {
                        emails.Add(user, new List<string>());
                    }
                }
                else if (words[0].Equals("Send"))
                {
                    string user = words[1];
                    string email = words[2];
                    emails[user].Add(email);
                }
                else
                {
                    string user = words[1];
                    if(emails.ContainsKey(user))
                    {
                        emails.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine($"{user} not found!");
                    }
                }
                command = Console.ReadLine();
            }
            emails = emails.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Users count: {emails.Keys.Count}");
            foreach(var item in emails)
            {
                Console.WriteLine($"{item.Key}");
                foreach(var email in item.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
