using P02_CarsSalesman.Entities;
using P02_CarsSalesman.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman.Factories
{
    class CarFactory : ICarFactory
    {
        private EngineRepository engineRepository;
        public CarFactory(EngineRepository engineRepository)
        {
            this.engineRepository = engineRepository;
        }
        public Car CreateCar(string[] parameters)
        {
            
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = this.engineRepository.FindEngine(engineModel);

            int weight = -1;

            Car car = null;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                car = new Car(model, engine, weight);
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                car = new Car(model, engine, color);
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                car = new Car(model, engine, int.Parse(parameters[2]), color);
            }
            else
            {
                car = new Car(model, engine);
            }

            return car;
        }
    }
}
