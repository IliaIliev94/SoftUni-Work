using P02_CarsSalesman.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman.Factories
{
    public interface ICarFactory
    {
        Car CreateCar(string[] parameters);
    }
}
