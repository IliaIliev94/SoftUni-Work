using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(!command.Equals("End"))
            {
                string[] commands = command.Split();

                if (commands[0].Equals("Add"))
                {
                    nums.Add(int.Parse(commands[1]));
                }
                else if (commands[0].Equals("Insert"))
                {
                    int element = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index > nums.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        nums.Insert(index, element);
                    }
                }
                else if (commands[0].Equals("Remove"))
                {
                    int index = int.Parse(commands[1]);

                    if (index > nums.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (commands[0].Equals("Shift"))
                {
                    int count = int.Parse(commands[2]);
                    if (commands[1].Equals("left"))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            nums.Add(nums[0]);
                            nums.RemoveAt(0);
                        }
                    }
                    else
                    {

                        for (int i = 0; i < count; i++)
                        {
                            nums.Insert(0, nums[nums.Count - 1]);
                            nums.RemoveAt(nums.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
