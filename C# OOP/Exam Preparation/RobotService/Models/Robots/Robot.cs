using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Utilities.Messages;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {
        private int hapiness;
        private int energy;
        public string Name { get; }
        public int Happiness 
        { 
            get
            {
                return this.hapiness;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHappiness);
                }
                this.hapiness = value;
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
                if(value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                this.energy = value;
            }
        }
        public int ProcedureTime { get; set; }
        public virtual string Owner { get; set; } = "Service";
        public bool IsBought { get; set; } = false;
        public bool IsChipped { get; set; } = false;
        public bool IsChecked { get; set; } = false;

        protected Robot(string name, int energy, int hapiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = hapiness;
            this.ProcedureTime = procedureTime;
        }

        public override string ToString()
        {
            return $" Robot type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
