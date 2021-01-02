using System;
using System.Collections.Generic;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<int>>> dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();
            Dictionary<string, List<double>> averageValues = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split();
                string dragonType = dragonInfo[0];
                string dragonName = dragonInfo[1];
                int dragonDamage = 45;
                if (dragonInfo[2] != "null")
                {
                    dragonDamage = int.Parse(dragonInfo[2]);
                }

                int dragonHealth = 250;
                if (dragonInfo[3] != "null")
                {
                    dragonHealth = int.Parse(dragonInfo[3]);
                }
                int dragonArmor = 10;
                if (dragonInfo[4] != "null")
                {
                    dragonArmor = int.Parse(dragonInfo[4]);
                }
                

                if (!dragons.ContainsKey(dragonType))
                {
                    SortedDictionary<string, List<int>> temp = new SortedDictionary<string, List<int>>();
                    temp.Add(dragonName, new List<int> { dragonDamage, dragonHealth, dragonArmor });
                    dragons.Add(dragonType, temp);
                }
                else
                {
                    if (!dragons[dragonType].ContainsKey(dragonName))
                    {
                        dragons[dragonType].Add(dragonName, new List<int> { dragonDamage, dragonHealth, dragonArmor });
                    }
                    else
                    {
                        dragons[dragonType][dragonName] = new List<int> { dragonDamage, dragonHealth, dragonArmor };
                    }
                }

            }
            foreach (var item in dragons)
            {
                foreach (var mini in item.Value)
                {
                    if (averageValues.ContainsKey(item.Key))
                    {
                        averageValues[item.Key][0] += mini.Value[0];
                        averageValues[item.Key][1] += mini.Value[1];
                        averageValues[item.Key][2] += mini.Value[2];
                    }
                    else
                    {
                        averageValues.Add(item.Key, new List<double> { mini.Value[0], mini.Value[1], mini.Value[2] });
                    }
                }
            }
            foreach(var item in averageValues)
            {
                item.Value[0] /= dragons[item.Key].Count;
                item.Value[1] /= dragons[item.Key].Count;
                item.Value[2] /= dragons[item.Key].Count;
            }
            foreach (var item in dragons)
            {
                Console.WriteLine($"{item.Key}::({averageValues[item.Key][0].ToString("0.00")}/{averageValues[item.Key][1].ToString("0.00")}/{averageValues[item.Key][2].ToString("0.00")})");
                foreach (var mini in item.Value)
                {
                    Console.WriteLine($"-{mini.Key} -> damage: {mini.Value[0]}, health: {mini.Value[1]}, armor: {mini.Value[2]}");
                }
            }
        }
    }
}
