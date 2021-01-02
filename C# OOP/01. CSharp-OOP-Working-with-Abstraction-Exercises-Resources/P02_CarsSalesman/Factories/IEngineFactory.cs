using P02_CarsSalesman.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman.Factories
{
    public interface IEngineFactory
    {
        Engine CreateEngine(string[] parameters);
    }
}
