using System;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Priest : Character, IHealer
    {
        public override double BaseHealth { get; } = 50;
        public override double BaseArmor { get; } = 25;

        public Priest(string name) : base(name, 50, 25, 40, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            character.Health += this.AbilityPoints;
        }
    }
}