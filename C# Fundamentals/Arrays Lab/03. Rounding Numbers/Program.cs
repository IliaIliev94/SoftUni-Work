using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesArray = values.Split();
            int[] nums = new int[valuesArray.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                double number = double.Parse(valuesArray[i]);
                nums[i] = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(Decimal)number} => {nums[i]}");
            }
        }
    }
}
