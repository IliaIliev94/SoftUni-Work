using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Tesla", 2);
            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
}
