using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> party;
		private List<Item> itemsPool;
		public WarController()
		{
			party = new List<Character>();
			itemsPool = new List<Item>();
		}

		public string JoinParty(string[] args)
		{
			var type = args[0];
			var name = args[1];

			if (!type.Equals("Warrior") && !type.Equals("Priest"))
			{
				throw new ArgumentException(String.Format(ExceptionMessages.InvalidCharacterType, type));
			}
			party.Add(CreateCharacter(type, name) );
			return String.Format(SuccessMessages.JoinParty, name);
		}

		public string AddItemToPool(string[] args)
		{
			var type = args[0];
			if (!type.Equals("FirePotion") && !type.Equals("HealthPotion"))
			{
				throw new ArgumentException(String.Format(ExceptionMessages.InvalidItem, type));
			}
			itemsPool.Add(CreateItem(type));
			return String.Format(SuccessMessages.AddItemToPool, type);
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];
			if (party.FirstOrDefault(character => character.Name.Equals(characterName)) == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, characterName));
			}
			else if (itemsPool.Count <= 0)
			{
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
			}

			Character character = party.FirstOrDefault(character => character.Name.Equals(characterName));
			Item item = itemsPool[itemsPool.Count - 1];
			character.Bag.AddItem(item);
			itemsPool.RemoveAt(itemsPool.Count - 1);
			return String.Format(SuccessMessages.PickUpItem, characterName, item.GetType().Name);
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];
			Character character = party.FirstOrDefault(character => character.Name.Equals(characterName));
			if (character == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, characterName));
			}
			character.UseItem(character.Bag.GetItem(itemName));
			return String.Format(SuccessMessages.UsedItem, characterName, itemName);
		}

		public string GetStats()
		{
			party = party.OrderByDescending(player => player.IsAlive).ThenByDescending(player => player.Health).ToList();
			StringBuilder result = new StringBuilder();
			var count = party.Count;
			var counter = 0;
			foreach (var character in party)
			{
				var status = character.IsAlive ? "Alive" : "Dead";

					result.AppendLine(
						$"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");

					counter++;
			}

			return result.ToString().Trim();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string attackedName = args[1];
			Character attacker = party.FirstOrDefault(player => player.Name == attackerName);
			Character attacked = party.FirstOrDefault(player => player.Name == attackedName);

			if (attacker == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, attackerName));
			}
			else if (attacked == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, attackedName));
			}
			else if (!attacker.IsAlive)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.AttackFail, attackerName));
			}

			var convertedAttacker = (IAttacker) attacker;
			convertedAttacker.Attack(attacked);
			if (attacked.IsAlive)
			{
				return String.Format(SuccessMessages.AttackCharacter, attackerName, attackedName,
					attacker.AbilityPoints, attackedName, attacked.Health, attacked.BaseHealth, attacked.Armor, attacked.BaseArmor);
			}
			return String.Format(SuccessMessages.AttackCharacter, attackerName, attackedName,
				       attacker.AbilityPoints, attackedName, attacked.Health, attacked.BaseHealth, attacked.Armor, attacked.BaseArmor) + Environment.NewLine + String.Format(SuccessMessages.AttackKillsCharacter, attackedName);
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healedName = args[1];
			Character healer = party.FirstOrDefault(player => player.Name == healerName);
			Character healed = party.FirstOrDefault(player => player.Name == healedName);

			if (healer == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, healerName));
			}
			else if (healed == null)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, healedName));
			}
			else if (!healer.IsAlive)
			{
				throw new ArgumentException(String.Format(ExceptionMessages.HealerCannotHeal, healerName));
			}

			var convertedHealer = (IHealer) healer;
			convertedHealer.Heal(healed);
			return String.Format(SuccessMessages.HealCharacter, healerName, healedName,
				healer.AbilityPoints, healedName, healed.Health);
		}

		private Character CreateCharacter(string type, string name)
		{
			Character character = null;
			switch (type)
			{
				case "Warrior":
					character = new Warrior(name);
					break;
				default:
					character = new Priest(name);
					break;
			}

			return character;
		}

		private Item CreateItem(string type)
		{
			Item item = null;
			switch (type)
			{
				case "FirePotion":
					item = new FirePotion();
					break;
				default:
					item = new HealthPotion();
					break;
			}

			return item;
		}
	}


}
