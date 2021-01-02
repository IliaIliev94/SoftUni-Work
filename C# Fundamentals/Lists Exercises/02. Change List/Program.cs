using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while(!command[0].Equals("end"))
            {
                if (command[0].Equals("Delete"))
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == int.Parse(command[1]))
                        {
                            nums.Remove(nums[i]);
                        }
                    }
                }
                else
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split();
            }
            
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
