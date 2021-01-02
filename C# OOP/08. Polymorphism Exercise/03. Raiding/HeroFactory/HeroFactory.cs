using System;
using System.Collections.Generic;
using System.Text;
using _03._Raiding.Models;

namespace _03._Raiding.HeroFactory
{
    public class HeroFactory : IHeroFactory
    {
        public IBaseHero CreateHero(string type, string name)
        {
            IBaseHero hero = null;
            if(type.Equals("Druid"))
            {
                hero = new Druid(name);
            }
            else if(type.Equals("Paladin"))
            {
                hero = new Paladin(name);
            }
            else if(type.Equals("Rogue"))
            {
                hero = new Rogue(name);
            }
            else if(type.Equals("Warrior"))
            {
                hero = new Warrior(name);
            }
            return hero;
        }
    }
}
