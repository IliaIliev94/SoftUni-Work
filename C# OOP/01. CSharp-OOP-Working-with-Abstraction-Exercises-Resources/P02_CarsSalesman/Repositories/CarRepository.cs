using P02_CarsSalesman.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman.Repositories
{
    public class CarRepository
    {
        public CarRepository()
        {
            this.cars = new List<Car>();
        }

        private readonly List<Car> cars;

        public IReadOnlyCollection<Car> Cars 
        { 
            get
            {
                return this.cars.AsReadOnly();
            } 
        }

        public void AddCar(Car car)
        {
            this.cars.Add(car);
        }
    }
}
