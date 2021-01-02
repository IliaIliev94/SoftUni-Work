using System;

namespace _01._Buscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuits = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingBiscuits = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= 30; i++)
            {
                int output = 0;
                if (i % 3 == 0)
                {
                    output = (int)(biscuits * workers * 0.75);
                }
                else
                {
                    output = biscuits * workers;
                }
                sum += output;
            }
            Console.WriteLine($"You have produced {sum} biscuits for the past month.");
            if (sum > competingBiscuits)
            {
                Console.WriteLine($"You produce {((sum - competingBiscuits)* 1.0 /competingBiscuits * 100).ToString("0.00")} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {((competingBiscuits - sum)* 1.0 /competingBiscuits * 100).ToString("0.00")} percent less biscuits.");

            }
        }
    }
}
