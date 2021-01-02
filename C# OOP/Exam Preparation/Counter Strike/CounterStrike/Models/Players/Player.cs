using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;
        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                this.username = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
                this.health = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
                this.armor = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return this.gun;
            }
            private set
            {
                if(value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
                this.gun = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.Health > 0;
            }
        }

        public void TakeDamage(int points)
        {
            while(points != 0)
            {
                if(armor > 0)
                {
                    if(armor >= points)
                    {
                        this.Armor -= points;
                        points = 0;
                    }
                    else
                    {
                        points -= this.Armor;
                        this.Armor = 0;
                    }
                }
                else
                {
                    if(health >= points)
                    {
                        this.Health -= points;
                        points = 0;
                    }
                    else
                    {
                        this.Health = 0;
                        break;
                    }
                }
            }
        }

        public Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.GetType().Name}: {this.Username}");
            result.AppendLine($"--Health: {this.Health}");
            result.AppendLine($"--Armor: {this.Armor}");
            result.Append($"--Gun: {this.Gun.Name}");
            return result.ToString();
        }
    }
}
