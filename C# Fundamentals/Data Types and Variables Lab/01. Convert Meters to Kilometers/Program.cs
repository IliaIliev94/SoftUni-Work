using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double result = num / 1000;

            Console.WriteLine(result.ToString("0.00"));
        }
    }
}
