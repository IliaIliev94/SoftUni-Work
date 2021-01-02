using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> largestInts = new List<int>();
            for (int i = 0; i < 3 && nums.Count > 0; i++)
            {
                int largest = nums.Max();
                largestInts.Add(largest);
                nums.Remove(largest);

            }
            Console.WriteLine(string.Join(" ", largestInts));
        }
    }
}
