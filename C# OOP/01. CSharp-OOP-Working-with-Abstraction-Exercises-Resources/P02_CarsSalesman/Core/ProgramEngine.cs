using P02_CarsSalesman.Entities;
using P02_CarsSalesman.Factories;
using P02_CarsSalesman.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman.Core
{
    public class ProgramEngine : IProgramEngine
    {
        public ProgramEngine()
        {
            this.carRepository = new CarRepository();
            this.engineRepository = new EngineRepository();
            this.carFactory = new CarFactory(this.engineRepository);
            this.engineFactory = new EngineFactory();
        }

        private CarRepository carRepository;
        private EngineRepository engineRepository;
        private ICarFactory carFactory;
        private IEngineFactory engineFactory;
        public void Run()
        {
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Engine engine = this.engineFactory.CreateEngine(engineParameters);
                engineRepository.AddEngine(engine);
            }
            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] carParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Car car = this.carFactory.CreateCar(carParameters);
                carRepository.AddCar(car);
            }

            foreach (var car in this.carRepository.Cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
