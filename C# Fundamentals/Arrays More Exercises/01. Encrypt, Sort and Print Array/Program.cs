using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    char c = char.ToLower(name[j]);
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        sum += (int)name[j] * name.Length;
                    }
                    else
                    {
                        sum += (int)name[j] / name.Length;
                    }
                }
                nums[i] = sum;
            }
             for (int i = 0; i < nums.Length; i++)
            {
                int min = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            } 
            Console.WriteLine(string.Join("\n", nums));
        }
    }
}
