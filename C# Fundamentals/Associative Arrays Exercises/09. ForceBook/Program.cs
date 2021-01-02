using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while(!command.Equals("Lumpawaroo"))
            {
                string[] commandType = command.Split();

                if (commandType.Contains("|"))
                {
                    string[] info = command.Split(" | ");
                    string forceSide = info[0];
                    string forceUser = info[1];

                    bool contains = false;
                    foreach(var item in forceSides)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            if (item.Value[i] == forceUser)
                            {
                                contains = true;
                            }
                        }
                    }
                    if (!contains)
                    {
                        if (forceSides.ContainsKey(forceSide))
                        {
                            forceSides[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceSides.Add(forceSide, new List<string> { forceUser });
                        }
                    }
                }

                else if (commandType.Contains("->"))
                {
                    string[] info = command.Split(" -> ");
                    string forceUser = info[0];
                    string forceSide = info[1];
                    foreach (var item in forceSides)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            if (item.Value[i] == forceUser)
                            {
                                item.Value.Remove(forceUser);
                            }
                        }
                    }
                    if (forceSides.ContainsKey(forceSide))
                    {
                        forceSides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        forceSides.Add(forceSide, new List<string> { forceUser });
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                command = Console.ReadLine();
            }
            forceSides = forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in forceSides)
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    item.Value.Sort((x, y) => x.CompareTo(y));
                }
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"! {item.Value[i]}");
                }
            }
        }
    }
}
