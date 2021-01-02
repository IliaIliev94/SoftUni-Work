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
        private int numberOfWins;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }
                this.name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins
        {
            get
            {
                return this.numberOfWins;
            }
            private set
            {
                this.numberOfWins = value;
            }
        }

        public bool CanParticipate
        {
            get
            {
                return Car != null;
            }
            private set
            {
                this.CanParticipate = false;
            }
        }

        public void AddCar(ICar car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(string.Format(ExceptionMessages.CarInvalid));
            }
            this.Car = car;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public Driver(string name)
        {
            this.Name = name;
            this.numberOfWins = 0;
        }
    }
}
