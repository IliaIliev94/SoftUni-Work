using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    class DriverRepository : Repository<IDriver>, IRepository<IDriver>
    {
        

        public override IDriver GetByName(string name)
        {
            return this.Model.FirstOrDefault(x => x.Name == name);
        }

        public DriverRepository() : base()
        {
        }
    }
}
