using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Football_Team_Generator
{
    public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                return this.rating;
            }
            private set
            {
                this.rating = value;
            }
        }

        public IReadOnlyCollection<Player> Players
        {
            get
            {
                return this.players.AsReadOnly();
            }
        }

        public int GetRating()
        {
            double result = 0;
            foreach(var item in this.players)
            {
                result += item.Skill;
            }
            if(this.players.Count < 1)
            {
                return (int)result;
            }
            return (int)Math.Round(result / this.players.Count);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string player)
        {
            int index = this.players.FindIndex(x => x.Name == player);
            if(index == -1)
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }
            this.players.RemoveAt(index);
        }

        public Team (string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetRating()}";
        }
    }
}
