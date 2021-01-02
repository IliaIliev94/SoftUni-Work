using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Template
{
    public class Sourdough : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread. (20 minutes)");
        }

        public override void MixIngridients()
        {
            Console.WriteLine("Gathering Ingridients for Sourdough Bread.");
        }
    }
}
