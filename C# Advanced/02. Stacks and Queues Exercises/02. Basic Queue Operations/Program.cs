using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();

            for(int i = 0; i < data[0]; i++)
            {
                nums.Enqueue(numbers[i]);
            }
            for(int i = 0; i < data[1]; i++)
            {
                nums.Dequeue();
            }

            if(nums.Count < 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool isFound = false;
                int min = int.MaxValue;
                while(nums.Count != 0 && isFound == false)
                {
                    int temp = nums.Dequeue();
                    if(temp == data[2])
                    {
                        isFound = true;
                    }
                    else if(temp < min)
                    {
                        min = temp;
                    }
                }
                if(isFound)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(min);
                }
            }
        }
    }
}
