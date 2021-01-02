using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}{Environment.NewLine}DJAAF";
        }
    }
}
