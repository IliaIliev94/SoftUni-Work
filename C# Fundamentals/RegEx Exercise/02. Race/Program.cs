using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> results = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while(!command.Equals("end of race"))
            {
                for(int i = 0; i < input.Count; i++)
                {
                    string pattern = @"[A-Za-z]";
                    MatchCollection temp = Regex.Matches(command, pattern);
                    string name = new string("");
                    foreach(Match item in temp)
                    {
                        name += item.Value;
                    }
                    if(input.Contains(name))
                    {
                        MatchCollection numbers = Regex.Matches(command, @"[0-9]");
                        int sum = 0;
                        foreach(Match item in numbers)
                        {
                            sum += int.Parse(item.Value);
                        }
                        if (results.ContainsKey(name))
                        {
                            results[name] += sum;
                        }
                        else
                        {
                            results.Add(name, sum);
                        } 
                    }
                }
                command = Console.ReadLine();
            }
            results = results.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int counter = 0;
            foreach(var item in results)
            {
                if(counter == 0)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 1)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
