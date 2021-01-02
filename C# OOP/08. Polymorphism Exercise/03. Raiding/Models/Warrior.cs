using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Raiding.Models
{
    public class Warrior : BaseHero
    {
        public override int Power { get; } = 100;

        public Warrior(string name) : base(name)
        {

        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
