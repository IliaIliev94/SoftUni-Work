using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> isGoing = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[2].Equals("going!"))
                {
                    if (!isGoing.Contains(command[0]))
                    {
                        isGoing.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    if (isGoing.Contains(command[0]))
                    {
                        isGoing.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < isGoing.Count; i++)
            {
                Console.WriteLine(isGoing[i]);
            }
            
        }
    }
}
