using EasterRaces.Models.Cars.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    class CarRepository : Repository<ICar>, IRepository<ICar>
    {
        

        public CarRepository() : base()
        {

        }

        public override ICar GetByName(string name)
        {
            return this.Model.FirstOrDefault(x => x.Model == name);
        }
    }
}
