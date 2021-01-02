using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            materials.Add("fragments", 0);
            materials.Add("shards", 0);
            materials.Add("motes", 0);
            string forgedMaterial = "";
            while(materials["shards"] < 250 && materials["fragments"] < 250 && materials["motes"] < 250)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    string material = input[i + 1].ToLower();
                    int amount = int.Parse(input[i]);
                    if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
                    {

                        materials[material] += amount;
                        if (materials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            forgedMaterial = "shards";
                            break;
                        }
                        else if (materials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            forgedMaterial = "fragments";
                            break;
                        }
                        else if (materials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            forgedMaterial = "motes";
                            break;
                        }

                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += amount;
                        }
                        else
                        {
                            junk.Add(material, amount);
                        }
                    }
                }
                
            }
            materials[forgedMaterial] -= 250;
            materials = materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach(var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
