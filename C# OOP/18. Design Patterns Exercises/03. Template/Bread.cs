using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Template
{
    public abstract class Bread
    {
        public abstract void MixIngridients();
        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + this.GetType().Name);
        }

        public void Make()
        {
            MixIngridients();
            Bake();
            Slice();
        }
    }
}
