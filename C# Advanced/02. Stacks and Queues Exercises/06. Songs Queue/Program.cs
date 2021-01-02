using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

            while(songs.Count != 0)
            {
                string command = Console.ReadLine();
                if(command.Equals("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Equals("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else
                {
                    string[] commands = command.Split(" ", 2);
                    if(songs.Contains(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(commands[1]);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
