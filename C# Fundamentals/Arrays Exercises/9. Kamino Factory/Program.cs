using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] nums = new int[n];
            int[] largest = new int[n];
            int maxCountAll = int.MinValue;
            int smallestIndexAll = int.MaxValue;
            string[] separatingStrings = new string[1];
            int numCount = 0, DNA = 0, maxSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (!Char.IsDigit(input[i]))
                {
                    separatingStrings[0] += input[i];
                }
                else
                {
                    if (numCount > 0)
                    {
                        break;
                    }
                    numCount++;
                }
            }
            for (int i = 1; !input.Equals("Clone them!"); i++)
            {
                int sum = 0;
                int count = 0;
                int index = 0;
                int maxCount = 0;
                int smallestIndex = int.MaxValue;
                bool isFound = false;
                nums = input.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == 1)
                    {
                        if (isFound == false)
                        {
                            index = j + 1;
                            isFound = true;
                        }
                        count++;
                    }
                    else
                    {
                        isFound = false;
                        count = 0;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        smallestIndex = index;
                    }
                    sum += nums[j];
                }
                if (maxCount > maxCountAll)
                {
                    largest = nums;
                    maxCountAll = maxCount;
                    smallestIndexAll = smallestIndex;
                    maxSum = sum;
                    DNA = i;
                }
                else if (maxCount == maxCountAll && smallestIndex < smallestIndexAll)
                {
                    largest = nums;
                    maxCountAll = maxCount;
                    smallestIndexAll = smallestIndex;
                    maxSum = sum;
                    DNA = i;
                }
                else if (maxCount == maxCountAll && smallestIndex == smallestIndexAll && sum > maxSum)
                {
                    largest = nums;
                    maxCountAll = maxCount;
                    smallestIndexAll = smallestIndex;
                    maxSum = sum;
                    DNA = i;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {DNA} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", largest));
        }
    }
}
