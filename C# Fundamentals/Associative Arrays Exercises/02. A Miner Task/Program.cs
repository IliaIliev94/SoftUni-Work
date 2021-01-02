using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (!resource.Equals("stop"))
            {
                int amount = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += amount;
                }
                else
                {
                    resources.Add(resource, amount);
                }
                resource = Console.ReadLine();
            }
            
            foreach(var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
