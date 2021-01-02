using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    class CarRepository : IRepository<ICar>
    {
        private List<ICar> models;
        public CarRepository()
        {
            models = new List<ICar>();
        }

        public void Add(ICar model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return models;
        }

        public ICar GetByName(string name)
        {
            return models.FirstOrDefault(car => car.Model == name);
        }

        public bool Remove(ICar model)
        {
            return models.Remove(model);
        }
    }
}
