using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();
            for(int i = 0; i < data[0]; i++)
            {
                nums.Push(numbers[i]);
            }
            for(int i = 0; i < data[1]; i++)
            {
                nums.Pop();
            }
            int smallest = int.MaxValue;
            bool isFound = false;
            if(nums.Count < 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (nums.Count != 0 && isFound == false)
                {
                    int num = nums.Pop();
                    if (num == data[2])
                    {
                        isFound = true;
                    }
                    else if (num < smallest)
                    {
                        smallest = num;
                    }
                }
                if(isFound)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(smallest);
                }
            }
           
        }
    }
}
