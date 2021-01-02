using System;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums1 = new int[n];
            int[] nums2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int input1 = int.Parse(numbers[0]);
                int input2 = int.Parse(numbers[1]);

                if (i % 2 == 0)
                {
                    nums1[i] = input1;
                    nums2[i] = input2;
                }
                else
                {
                    nums1[i] = input2;
                    nums2[i] = input1;
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                if (i != nums1.Length - 1)
                {
                    Console.Write($"{nums1[i]} ");
                }
                else
                {
                    Console.WriteLine(nums1[i]);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (i != nums2.Length - 1)
                {
                    Console.Write($"{nums2[i]} ");
                }
                else
                {
                    Console.WriteLine(nums2[i]);
                }
            }
        }
    }
}
