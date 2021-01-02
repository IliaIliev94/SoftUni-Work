using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public abstract class Soldier : ISoldier
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        protected Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
