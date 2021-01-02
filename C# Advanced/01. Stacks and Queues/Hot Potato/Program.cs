using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> people = new Queue<string>();
            foreach (string name in input)
            {
                people.Enqueue(name);
            }
            while (people.Count > 1)
            {
                int counter = n;
                for (int i = 0; i < n; i++)
                {
                    if (counter > 1)
                    {
                        people.Dequeue();
                        people.Enqueue(input[i % input.Length]);
                        counter--;
                    }
                    else
                    {
                        Console.WriteLine($"Removed {people.Dequeue()}");
                    }

                }
                input = people.ToArray();
            }
            Console.WriteLine($"Last is {people.Peek()}");

        }
    }
}