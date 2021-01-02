using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDaysMined = 0;
            long spiceConsumned = 0;
            int spiceSource = int.Parse(Console.ReadLine());
            for (int i = spiceSource; i >= 100; i-= 10)
            {
                spiceConsumned += i - 26;
                totalDaysMined++;
            }
            if (spiceConsumned >= 26)
            {
                spiceConsumned -= 26;
            }
            
            Console.WriteLine(totalDaysMined);
            Console.WriteLine(spiceConsumned);
        }
    }
}
