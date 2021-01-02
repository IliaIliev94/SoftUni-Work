using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : Repository<IRace>, IRepository<IRace>
    {
        

        public RaceRepository() : base()
        {
            
        }

        public override IRace GetByName(string name)
        {
            return this.Model.FirstOrDefault(x => x.Name == name);
        }
    }
}
