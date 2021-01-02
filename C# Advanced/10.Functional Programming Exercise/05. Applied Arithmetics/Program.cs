using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string, int> operation = (x, s) =>
            {
                if(s == "add")
                {
                    return x + 1;
                }
                else if(s == "multiply")
                {
                    return x * 2;
                }
                else
                {
                    return x - 1;
                }
            };
            Action<List<int>> Print = x => Console.WriteLine(string.Join(" ", x));
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(!command.Equals("end"))
            {
                if(command != "print")
                {
                    nums = nums.Select(x => operation(x, command)).ToList();
                }
                else
                {
                    Print(nums);
                }
                command = Console.ReadLine();
            }
        }
        public static List<int> ArithmeticOperation(List<int> nums, Func<int, string, int> Operation, string command)
        {
            List<int> result = new List<int>();

            foreach(var num in nums)
            {
                result.Add(Operation(num, command));
            }
            return result;
        }
    }
}
