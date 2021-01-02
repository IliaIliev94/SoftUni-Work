using System;

namespace _03._Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread breadDough = new Sourdough();
            breadDough.Make();

            Bread twelveGrain = new TwelveGrain();
            twelveGrain.Make();
        }
    }
}
