using System;
using System.Collections.Generic;
using System.Linq;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        public List<IPlayer> models;

        public IReadOnlyCollection<IPlayer> Models
        {
            get { return this.models.AsReadOnly(); }
        }
        public void Add(IPlayer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }
            models.Add(model);
        }

        public bool Remove(IPlayer model)
        {
            return models.Remove(model);
        }

        public IPlayer FindByName(string name)
        {
            return models.FirstOrDefault(model => model.Username == name);
        }

        public PlayerRepository()
        {
            this.models = new List<IPlayer>();
        }
    }
}