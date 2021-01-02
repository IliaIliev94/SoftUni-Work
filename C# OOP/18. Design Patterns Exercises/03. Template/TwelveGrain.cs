using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Template
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }

        public override void MixIngridients()
        {
            Console.WriteLine("Gathering Ingridients for 12-Grain Bread.");
        }
    }
}
