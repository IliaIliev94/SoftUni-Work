using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdentical = true;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != nums2[i])
                {
                    isIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                sum += nums1[i];
            }

            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
