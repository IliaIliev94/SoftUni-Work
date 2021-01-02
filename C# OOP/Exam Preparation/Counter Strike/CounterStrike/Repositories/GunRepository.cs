using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> guns;
        public IReadOnlyCollection<IGun> Models
        {
            get
            {
                return this.guns.AsReadOnly();
            }
        }

        public void Add(IGun gun)
        {
            if(gun == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }
            guns.Add(gun);
        }

        public bool Remove(IGun gun)
        {
            return guns.Remove(gun);
        }

        public IGun FindByName(string name)
        {
            IGun gun = guns.FirstOrDefault(gun => gun.Name == name);
            return gun;
        }

        public GunRepository()
        {
            this.guns = new List<IGun>();
        }

    }
}
