using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double skill;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if(!IsInRange(value))
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                }
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (!IsInRange(value))
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (!IsInRange(value))
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (!IsInRange(value))
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }
                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (!IsInRange(value))
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }
                this.shooting = value;
            }
        }

        public double Skill
        {
            get
            {
                return this.skill;
            }
            private set
            {
                this.skill = value;
            }
        }
        private bool IsInRange(int value)
        {
            return value >= 0 && value <= 100;
        }

        private double GetSkill()
        {
            double result = this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting * 1.0;
            return result / 5.0;
            
        }
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.Skill = GetSkill();
        }
    }
}
