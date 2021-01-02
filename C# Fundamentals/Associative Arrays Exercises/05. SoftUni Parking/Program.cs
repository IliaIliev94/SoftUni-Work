using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> licensePlates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string command = commands[0];
                string username = commands[1];
                
                if (command.Equals("register"))
                {
                    string licensePlateNumber = commands[2];
                    if (licensePlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlates[username]}");
                    }
                    else
                    {
                        licensePlates.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    if (licensePlates.ContainsKey(username))
                    {
                        licensePlates.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }

            }
            foreach(var item in licensePlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
