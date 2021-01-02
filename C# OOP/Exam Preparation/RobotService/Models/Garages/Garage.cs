using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        public int Capacity { get; } = 10;
        private Dictionary<string, IRobot> robots = new Dictionary<string, IRobot>();
        public IReadOnlyDictionary<string, IRobot> Robots 
        { 
            get 
            {
                return this.robots;
            }
        }


        public void Manufacture(IRobot robot)
        {
            if(Robots.Count == Capacity)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughCapacity);
            }
            else if(Robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }
            robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if(!robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            robots[robotName].Owner = ownerName;
            robots[robotName].IsBought = true;
            robots.Remove(robotName);
        }
    }
}
