using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> demons = new Dictionary<string, double[]>();
            string[] input = Console.ReadLine().Split(",");
            string healthPattern = @"[^\d+\-*\/.]";
            string damagePattern = @"[-|+]?\d+\.?\d*";
            string multipliers = @"[*\/]";
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                MatchCollection health = Regex.Matches(input[i], healthPattern);
                double totalHealth = 0;
                foreach(Match match in health)
                {
                    totalHealth += (int)char.Parse(match.Value);
                }
                double totalDamage = 0;
                MatchCollection damage = Regex.Matches(input[i], damagePattern);
                foreach(Match match in damage)
                {
                    totalDamage += double.Parse(match.Value);
                }
                MatchCollection multiply = Regex.Matches(input[i], multipliers);
                foreach(Match match in multiply)
                {
                    if (match.Value == "*")
                    {
                        totalDamage *= 2;
                    }
                    else if(match.Value == "/")
                    {
                        totalDamage /= 2;
                    }
                }
                demons.Add(input[i], new double[] { totalHealth, totalDamage });
            }
            demons = demons.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1].ToString("0.00")} damage");
            }
        }
    }
}
