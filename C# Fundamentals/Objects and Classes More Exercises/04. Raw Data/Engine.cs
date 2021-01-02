using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    class Engine
    {
        public Engine(int EngineSpeed, int EnginePower)
        {
            this.EngineSpeed = EngineSpeed;
            this.EnginePower = EnginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
