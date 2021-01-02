using System;
using System.Collections.Generic;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<int> nums = new Stack<int>();
            foreach (var item in input)
            {
                nums.Push(int.Parse(item));
            }
            string[] command = Console.ReadLine().ToLower().Split();

            while(!command[0].Equals("end"))
            {
                if(command[0].Equals("add"))
                {
                    for(int i = 1; i < command.Length; i++)
                    {
                        nums.Push(int.Parse(command[i]));
                    }
                }
                else
                {
                    if(nums.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            nums.Pop();
                        }
                    }
                    
                }
                command = Console.ReadLine().ToLower().Split();
            }
            
            while(nums.Count > 1)
            {
                int first = nums.Pop();
                nums.Push(first + nums.Pop());
            }
            Console.WriteLine($"Sum: {nums.Peek()}");
        }
    }
}
