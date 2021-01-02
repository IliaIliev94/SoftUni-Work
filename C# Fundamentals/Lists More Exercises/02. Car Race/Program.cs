using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> cars = Console.ReadLine().Split().Select(double.Parse).ToList();
            int finish = cars.Count / 2;
            double first = 0;
            double second = 0;
            for(int i = 0; i < finish; i++)
            {
                if (cars[i] == 0)
                {
                    first *= 0.8;
                }
                else
                {
                    first += cars[i];
                }
                
            }
            for(int i = cars.Count - 1; i > finish; i--)
            {
                if (cars[i] == 0)
                {
                    second *= 0.8;
                }
                else
                {
                    second += cars[i];
                }
            }

            if (first < second)
            {
                if (first == (int)Math.Floor(first))
                {
                    Console.WriteLine($"The winner is left with total time: {first.ToString("0")}");
                }
                else
                {
                    Console.WriteLine($"The winner is left with total time: {first.ToString("0.0")}");
                }
                
            }
            else
            {
                if (second == (int)Math.Floor(second))
                {
                    Console.WriteLine($"The winner is right with total time: {second.ToString("0")}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {second.ToString("0.0")}");
                }
            }
        }
    }
}
