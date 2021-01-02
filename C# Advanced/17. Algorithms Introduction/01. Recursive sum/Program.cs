using System;
using System.Linq;

namespace _01._Recursive_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(input, 0));
        }

        public static int Sum(int[] arr, int counter)
        {
            if(counter == arr.Length - 1)
            {
                return arr[counter];
            }
            return arr[counter] + Sum(arr, counter + 1);
        }
    }
}
