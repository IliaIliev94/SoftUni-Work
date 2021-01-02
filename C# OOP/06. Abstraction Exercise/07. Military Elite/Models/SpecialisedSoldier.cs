using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public abstract class SpecialisedSoldier : Private
    {
        private string corps;
        public string Corps
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if(value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }
                this.corps = value;
            }
        }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
    }
}
