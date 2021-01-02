using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		// TODO: Implement the rest of the class.
		private string name;
		private double health;
		private double armor;
		public float AbilityPoints { get; set; }
		public Bag Bag { get; set; }

		abstract public double BaseHealth { get; }
		abstract public double BaseArmor { get; }

		public string Name
		{
			get { return this.name; }
			private set
			{
				if (String.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
				}

				this.name = value;
			}
		}

		public double Health
		{
			get { return this.health; }

			 set
			{
				if (value < 0)
				{
					this.health = 0;
					return;
				}

				if (value > BaseHealth)
				{
					this.health = BaseHealth;
					return;
				}

				this.health = value;
			}
		}
		
		public double Armor
		{
			get { return this.armor; }

			 set
			{
				if (value < 0)
				{
					this.armor = 0;
					return;
				}

				if (value > BaseArmor)
				{
					this.armor = BaseArmor;
					return;
				}

				this.armor = value;
			}
		}


		public bool IsAlive
		{
			get
			{
				return this.Health > 0;
			}
		}

		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}

		public void TakeDamage(double hitPoints)
		{
			if (this.IsAlive)
			{
				if (this.Armor > 0)
				{
					if (this.Armor >= hitPoints)
					{
						this.Armor -= (float)hitPoints;
						return;
					}
					else
					{
						hitPoints -= this.Armor;
						this.Armor = 0;
					}
				}

				this.Health -= hitPoints;
			}
		}

		public void UseItem(Item item)
		{
				EnsureAlive();

				item.AffectCharacter(this);
		}

		protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
		{
			this.Name = name;
			this.Health = health;
			this.Armor = armor;
			this.AbilityPoints = (float)abilityPoints;
			this.Bag = bag;
		}
    }
}