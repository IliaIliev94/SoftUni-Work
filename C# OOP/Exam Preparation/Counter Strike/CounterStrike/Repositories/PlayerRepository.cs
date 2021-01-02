using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CounterStrike.Repositories.Contracts
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private List<IPlayer> players;
        public IReadOnlyCollection<IPlayer> Models
        {
            get
            {
                return this.players;
            }
        }

        public void Add(IPlayer player)
        {
            if(player == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }
            this.players.Add(player);
        }

        public IPlayer FindByName(string name)
        {
            return this.players.FirstOrDefault(player => player.Username == name);
        }

        public bool Remove(IPlayer player)
        {
            return this.players.Remove(player);
        }

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }
    }
}
