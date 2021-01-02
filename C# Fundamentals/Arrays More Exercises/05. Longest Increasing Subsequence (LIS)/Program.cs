using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longest = 0;
            int position = -1;
            string longestString = "" + nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                int count = 1;
                int previous = i;
                bool reverse = false;
                string temp = "" + nums[i];
                bool isLarger = false;
                int largerPosition = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (reverse == true)
                    {
                        for (int k = i + 1; k < j; k++)
                        {
                            if (nums[k] < nums[j] && nums[k] > nums[previous])
                            {
                                count++;
                                previous = k;


                                temp += " " + nums[k];

                            }
                        }
                        reverse = false;
                    }
                    if (nums[j] > nums[i] && nums[j] > nums[previous])
                    {
                        count++;
                        previous = j;

                        temp += " " + nums[j];

                    }
                    else if(nums[j] < nums[i])
                    {
                        largerPosition = i;
                        isLarger = true;
                    }
                    else if (nums[j] > nums[i] && nums[j] < nums[previous] && position == -1)
                    {
                        position = j;
                    }
                    if (j == nums.Length - 1)
                    {
                        if (count > longest)
                        {
                            longest = count;
                            longestString = temp;
                        }
                        if (position != -1)
                        {
                            j = position;
                            count = 1;
                            reverse = true;
                            position = -1;
                            previous = i;
                            temp = "" + nums[i];
                        }
                    }
                }
                if(isLarger)
                {
                    i = largerPosition;
                    isLarger = false;
                }
            }

            Console.WriteLine(longestString);
        }
    }
}
