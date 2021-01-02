using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNums = new List<int>();
            int counter = 0;
            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
            {
                newNums.Add(nums1[i]);
                newNums.Add(nums2[i]);
                counter++;
            }

            for (int i = counter; i < Math.Max(nums1.Count, nums2.Count); i++)
            {
                if (nums1.Count > nums2.Count)
                {
                    newNums.Add(nums1[i]);
                }
                else
                {
                    newNums.Add(nums2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newNums));
        }
    }
}
