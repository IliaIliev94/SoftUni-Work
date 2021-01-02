using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidName, value, 5));
                }
                this.name = value;
            }
        }

        public ICar Car { get; set; }

        public int NumberOfWins { get; set; }

        public bool CanParticipate 
        { 
            get
            {
                return Car != null;
            }
        }

        public void AddCar(ICar car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }
            Car = car;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }

        public Driver(string name)
        {
            Name = name;
        }
    }
}
