using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            minDistance(num1, num2, num3, num4);
        }
        static void minDistance(double a, double b, double x, double y)
        {
            double sum1 = Math.Abs(a) + Math.Abs(b);
            double sum2 = Math.Abs(x) + Math.Abs(y);

            if (sum2 < sum1)
            {
                Console.WriteLine($"({x}, {y})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})");
            }
        }
    }
}
