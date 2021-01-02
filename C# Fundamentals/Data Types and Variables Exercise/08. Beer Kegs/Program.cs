using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string beerModel;
            double radius;
            int height;
            double volume;

            string largest = "";
            double maxVolume = 0;

            for (int i = 0; i < num; i++)
            {
                beerModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolume)
                {
                    largest = beerModel;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(largest);
        }
    }
}
