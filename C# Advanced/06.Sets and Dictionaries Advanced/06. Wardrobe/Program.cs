using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> clothes = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[]{ "->", " -> "}, StringSplitOptions.None);

                string[] dresses = input[1].Split(",", StringSplitOptions.None);
                if (clothes.ContainsKey(input[0]))
                {
                    foreach (var cloth in dresses)
                    {
                        if (clothes[input[0]].ContainsKey(cloth))
                        {
                            clothes[input[0]][cloth]++;
                        }
                        else
                        {
                            clothes[input[0]].Add(cloth, 1);
                        }
                    }
                }
                else
                {
                    Dictionary<string, long> temp = new Dictionary<string, long>();
                    foreach (var cloth in dresses)
                    {
                        if(temp.ContainsKey(cloth))
                        {
                            temp[cloth]++;
                        }
                        else
                        {
                            temp.Add(cloth, 1);
                        }
                            
                    }
                    clothes.Add(input[0], temp);
                }

                
            }
            string[] find = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach(var cloth in item.Value)
                {
                    if(item.Key == find[0] && cloth.Key == find[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
