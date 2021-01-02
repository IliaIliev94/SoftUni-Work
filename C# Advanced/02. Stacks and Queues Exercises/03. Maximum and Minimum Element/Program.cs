using System;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if(command[0] == '1')
                {
                    string[] data = command.Split();
                    int num = int.Parse(data[1]);
                    nums.Push(num);
                }
                else if(command[0] == '2')
                {
                    nums.Pop();
                }
                else if(command[0] == '3' && nums.Count > 0)
                {
                    int[] temp = nums.ToArray();
                    int max = int.MinValue;
                    for(int j = 0; j < temp.Length; j++)
                    {
                        int num = temp[j];
                        if(num > max)
                        {
                            max = num;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if(command[0] == '4' && nums.Count > 0)
                {
                    int[] temp = nums.ToArray();
                    int min = int.MaxValue;
                    for(int j = 0; j < temp.Length; j++)
                    {
                        int num = temp[j];
                        if(num < min)
                        {
                            min = num;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine(string.Join(", ", nums.ToArray()));
        }
    }
}
