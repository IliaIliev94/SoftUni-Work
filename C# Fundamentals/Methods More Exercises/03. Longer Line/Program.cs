using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());
            double num6 = double.Parse(Console.ReadLine());
            double num7 = double.Parse(Console.ReadLine());
            double num8 = double.Parse(Console.ReadLine());

            longerLine(num1, num2, num3, num4, num5, num6, num7, num8);
        }
        static void minDistance(double a, double b, double x, double y)
        {
            double sum1 = Math.Abs(a) + Math.Abs(b);
            double sum2 = Math.Abs(x) + Math.Abs(y);

            if (sum2 < sum1)
            {
                Console.WriteLine($"({x}, {y})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({x}, {y})");
            }
        }
        static void longerLine(double one, double two, double three, double four,
            double five, double six, double seven, double eight)
        {
            double sum1 = Math.Abs(one) + Math.Abs(two) + Math.Abs(three) + Math.Abs(four);
            double sum2 = Math.Abs(five) + Math.Abs(six) + Math.Abs(seven) + Math.Abs(eight);

            if (sum2 > sum1)
            {
                minDistance(five, six, seven, eight);
            }
            else
            {
                minDistance(one, two, three, four);
            }
        }
    }
}
