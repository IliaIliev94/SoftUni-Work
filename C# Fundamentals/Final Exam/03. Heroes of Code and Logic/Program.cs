using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for(int i = 0; i < n; i++)
            {
                string[] heroData = Console.ReadLine().Split();
                string hero = heroData[0];
                int hp = int.Parse(heroData[1]);
                int mp = int.Parse(heroData[2]);
                if(!heroes.ContainsKey(hero))
                {
                    heroes.Add(hero, new List<int> { hp, mp });
                }
            }
            string command = Console.ReadLine();
            while(!command.Equals("End"))
            {
                string[] words = command.Split(" - ");
                string hero = words[1];
                if(words[0].Equals("CastSpell"))
                {
                    int mp = int.Parse(words[2]);
                    string spell = words[3];
                    if(heroes[hero][1] >= mp)
                    {
                        heroes[hero][1] -= mp;
                        Console.WriteLine($"{hero} has successfully cast {spell} and now has {heroes[hero][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
                    }
                }
                else if(words[0].Equals("TakeDamage"))
                {
                    int damage = int.Parse(words[2]);
                    string attacker = words[3];
                    heroes[hero][0] -= damage;
                    if(heroes[hero][0] > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                }
                else if(words[0].Equals("Recharge"))
                {
                    int amount = int.Parse(words[2]);
                    heroes[hero][1] += amount;
                    if(heroes[hero][1] > 200)
                    {
                        int old = heroes[hero][1] - amount;
                        heroes[hero][1] = 200;
                        amount = 200 - old;
                    }
                    Console.WriteLine($"{hero} recharged for {amount} MP!");
                }
                else
                {
                    int amount = int.Parse(words[2]);
                    heroes[hero][0] += amount;
                    if (heroes[hero][0] > 100)
                    {
                        int old = heroes[hero][0] - amount;
                        heroes[hero][0] = 100;
                        amount = 100 - old;
                    }
                    Console.WriteLine($"{hero} healed for {amount} HP!");
                }
                command = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in heroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"HP: {item.Value[0]}");
                Console.WriteLine($"MP: {item.Value[1]}");
            }
        }
    }
}
