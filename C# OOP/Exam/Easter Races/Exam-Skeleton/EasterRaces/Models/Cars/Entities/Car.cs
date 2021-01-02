using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string model;
        private int horsepower;
        protected abstract int MinHorsePower { get; }
        protected abstract int MaxHorsePower { get; }
        private double cubicCentimeters;
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel, value, 4));
                }
                this.model = value;
            }
        }

        public double CubicCentimeters
        {
            get
            {
                return this.cubicCentimeters;
            }
            private set
            {
                this.cubicCentimeters = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsepower;
            }
            private set
            {
                if(value < this.MinHorsePower || value > MaxHorsePower)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }
                this.horsepower = value;
            }
        }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }

        protected Car(string model, int horsepower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsepower;
            this.CubicCentimeters = cubicCentimeters;

        }
    }
}
