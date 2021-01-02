using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public new const double Grams = 250;
        public new const double Calories = 1000;
        public new const decimal CakePrice  = 5;

        public Cake(string name) : base(name, CakePrice, Grams, Calories )
        {
        }
    }
}
