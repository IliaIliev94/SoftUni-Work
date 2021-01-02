using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        public string Name { get; private set; }
        public abstract int Power { get; }
        public abstract string CastAbility();


        public BaseHero(string name)
        {
            this.Name = name;
        }
    }
}
