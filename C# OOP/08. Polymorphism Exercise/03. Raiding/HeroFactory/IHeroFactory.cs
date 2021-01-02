using System;
using System.Collections.Generic;
using System.Text;
using _03._Raiding.Models;

namespace _03._Raiding.HeroFactory
{
    public interface IHeroFactory
    {
        IBaseHero CreateHero(string type, string name);
    }
}
