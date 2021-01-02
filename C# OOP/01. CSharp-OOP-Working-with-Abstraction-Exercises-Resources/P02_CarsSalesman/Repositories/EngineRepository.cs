using P02_CarsSalesman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_CarsSalesman.Repositories
{
    public class EngineRepository
    {
        public EngineRepository()
        {
            this.engines = new List<Engine>();
        }

        private List<Engine> engines;

        public IReadOnlyCollection<Engine> Engines
        {
            get
            {
                return this.engines.AsReadOnly();
            }
        }

        public void AddEngine(Engine engine)
        {
            this.engines.Add(engine);
        }

        public Engine FindEngine(string engineModel)
        {
            return this.engines.FirstOrDefault(engine => engine.model == engineModel);
        }
    }
}
