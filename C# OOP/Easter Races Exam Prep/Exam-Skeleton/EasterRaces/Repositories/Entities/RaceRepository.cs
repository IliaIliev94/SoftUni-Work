using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        public RaceRepository()
        {
            this.models = new List<IRace>();
        }

        private List<IRace> models;

        public void Add(IRace model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return models;
        }

        public IRace GetByName(string name)
        {
            return models.FirstOrDefault(race => race.Name == name);
        }

        public bool Remove(IRace model)
        {
            return models.Remove(model);
        }
    }
}
