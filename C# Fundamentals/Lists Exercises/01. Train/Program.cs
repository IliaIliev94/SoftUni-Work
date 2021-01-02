using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (!command[0].Equals("end"))
            {
                if (command[0].Equals("Add"))
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passangers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= capacity)
                        {
                            wagons[i] += passangers;
                            passangers = 0;
                        }

                        if (passangers == 0)
                        {
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
