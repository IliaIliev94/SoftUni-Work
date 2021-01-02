using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> one = new HashSet<int>();
            HashSet<int> two = new HashSet<int>();

            for(int i = 0; i < sizes[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                one.Add(num);
            }
            for(int i = 0; i < sizes[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                two.Add(num);
            }
            List<int> uniqueNums = new List<int>();
            foreach(int num in one)
            {
                if(two.Contains(num))
                {
                    uniqueNums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueNums));
        }
    }
}
