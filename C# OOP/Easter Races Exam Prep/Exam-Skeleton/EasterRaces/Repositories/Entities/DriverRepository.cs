using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        public DriverRepository()
        {
            models = new List<IDriver>();
        }

        private List<IDriver> models;

        public void Add(IDriver model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return models;
        }

        public IDriver GetByName(string name)
        {
            return models.FirstOrDefault(driver => driver.Name == name);
        }

        public bool Remove(IDriver model)
        {
            return models.Remove(model);
        }
    }
}
