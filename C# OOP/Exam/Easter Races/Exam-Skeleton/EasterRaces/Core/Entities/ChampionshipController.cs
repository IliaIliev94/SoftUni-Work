using EasterRaces.Core.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private CarRepository carRepositories;
        private DriverRepository driverRepositories;
        private RaceRepository raceRepositories;
        public string AddCarToDriver(string driverName, string carModel)
        {
            if(driverRepositories.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            if(carRepositories.GetByName(carModel) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }
            ICar car = this.carRepositories.GetByName(carModel);
            this.driverRepositories.GetByName(driverName).AddCar(car);
            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            if(this.raceRepositories.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            if(this.driverRepositories.GetByName(driverName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            IDriver driver = this.driverRepositories.GetByName(driverName);
            this.raceRepositories.GetByName(raceName).AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = null;
            switch(type)
            {
                case "Muscle":
                    car = new MuscleCar(model, horsePower);
                    break;
                case "Sports":
                    car = new SportsCar(model, horsePower);
                    break;
            }
            if(carRepositories.GetByName(car.Model) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, car.Model));
            }
            carRepositories.Add(car);
            return string.Format(OutputMessages.CarCreated, car.GetType().Name, car.Model);
        }

        public string CreateDriver(string driverName)
        {
            
            if(this.driverRepositories.GetByName(driverName) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }
            IDriver driver = new Driver(driverName);
            driverRepositories.Add(driver);
            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            if(this.raceRepositories.GetByName(name) != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RaceExists, name));
            }
            IRace race = new Race(name, laps);
            this.raceRepositories.Add(race);
            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string StartRace(string raceName)
        {
            if(this.raceRepositories.GetByName(raceName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            else if(this.raceRepositories.GetByName(raceName).Drivers.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }
            IRace race = this.raceRepositories.GetByName(raceName);
            List<IDriver> drivers = this.raceRepositories.GetByName(raceName).Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();
            raceRepositories.Remove(race);
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format(OutputMessages.DriverFirstPosition, drivers[0].Name, raceName));
            result.AppendLine(string.Format(OutputMessages.DriverSecondPosition, drivers[1].Name, raceName));
            result.Append(string.Format(OutputMessages.DriverThirdPosition, drivers[2].Name, raceName));
            return result.ToString();
        }

        public ChampionshipController()
        {
            this.carRepositories = new CarRepository();
            this.driverRepositories = new DriverRepository();
            this.raceRepositories = new RaceRepository();
        }
    }
}
