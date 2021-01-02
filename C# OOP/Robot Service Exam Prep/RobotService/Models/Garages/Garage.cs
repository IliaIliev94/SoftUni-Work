using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        public int Capacity => 10;
        private readonly Dictionary<string, IRobot> robots;
        public IReadOnlyDictionary<string, IRobot> Robots
        {
            get
            {
                return robots;
            }
        }

        public Garage()
        {
            robots = new Dictionary<string, IRobot>();
        }

        public void Manufacture(IRobot robot)
        {
            if(Robots.Count + 1 > Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            else if(Robots.Keys.Contains(robot.Name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }
            robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            robots[robotName].IsBought = true;
            robots[robotName].Owner = ownerName;
            robots.Remove(robotName);
        }
    }
}
