using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Raiding.Models
{
    public class Paladin : BaseHero
    {
        public override int Power { get; } = 100;

        public Paladin(string name) : base(name)
        {

        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
