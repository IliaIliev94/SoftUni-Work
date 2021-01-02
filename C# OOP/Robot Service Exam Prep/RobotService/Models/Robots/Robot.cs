using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {
        private int happiness;
        private int energy;


        public string Name { get; private set; }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }
                this.happiness = value;
            }
        }
        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                this.energy = value;
            }
        }
        public int ProcedureTime { get; set; }
        public string Owner { get; set; } = "Service";
        public bool IsBought { get; set; } = false;
        public bool IsChipped { get; set; } = false;
        public bool IsChecked { get; set; } = false;

        public Robot(string name, int energy, int happiness, int procedureTime)
        {
            Name = name;
            Energy = energy;
            Happiness = happiness;
            ProcedureTime = procedureTime;
        }

        public override string ToString()
        {
            return $" Robot type: {this.GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";
        }
    }
}
