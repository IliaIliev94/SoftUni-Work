using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T> : IRepository<T>
    {
        public List<T> Model;
        public void Add(T model)
        {
            this.Model.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return this.Model.AsReadOnly();
        }

        public abstract T GetByName(string name);

        public bool Remove(T model)
        {
            return this.Model.Remove(model);
        }

        public Repository()
        {
            this.Model = new List<T>();
        }
    }
}
