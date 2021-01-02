using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> Parse = (s) => int.Parse(s);
            int[] nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();


            Func<int[], int> sum = (x) =>
            {
                int sum = 0;
                foreach (var num in x)
                {
                    sum += num;
                }
                return sum;
            };

            Action<int[]> count = x => Console.WriteLine(x.Length);

            count(nums);
            Console.WriteLine(sum(nums));
            
        }
        
    }
}
