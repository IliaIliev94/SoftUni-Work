using RobotService.Core.Contracts;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IGarage Garage { get; set; }

        private List<string> robotTypes = new List<string>()
        {
            "HouseholdRobot",
            "PetRobot",
            "WalkerRobot"
        };

        private List<IProcedure> procedures = new List<IProcedure>()
        {
            new Charge(),
            new Chip(),
            new TechCheck(),
            new Work(),
            new Polish(),
            new Rest()
        };
        public Controller(IGarage garage)
        {
            Garage = garage;
        }

        public string Charge(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("Charge")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.ChargeProcedure, robotName);
        }

        public string Chip(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("Chip")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.ChipProcedure, robotName);
        }
        public string History(string procedureType)
        {
            return procedures.FirstOrDefault(x => x.GetType().Name == procedureType).History();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            if (!this.robotTypes.Contains(robotType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            }
            IRobot robot = null;
            switch (robotType)
            {
                case "HouseholdRobot":
                    robot = new HouseholdRobot(name, energy, happiness, procedureTime);
                    break;
                case "PetRobot":
                    robot = new PetRobot(name, energy, happiness, procedureTime);
                    break;
                case "WalkerRobot":
                    robot = new WalkerRobot(name, energy, happiness, procedureTime);
                    break;
            }
            Garage.Manufacture(robot);
            return $"Robot {name} registered successfully";
        }

        private void RobotExists(string name)
        {
            if(!Garage.Robots.ContainsKey(name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, name));
            }
        }

        public string Polish(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("Polish")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.PolishProcedure, robotName);
        }

        public string Rest(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("Rest")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.RestProcedure, robotName);
        }

        public string Sell(string robotName, string ownerName)
        {
            RobotExists(robotName);
            IRobot robot = Garage.Robots.FirstOrDefault(robot => robot.Key == robotName).Value;
            Garage.Sell(robotName, ownerName);
            if(robot.IsChipped == true)
            {
                return string.Format(OutputMessages.SellChippedRobot, ownerName);
            }
            else
            {
                return string.Format(OutputMessages.SellNotChippedRobot, ownerName);
            }
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("TechCheck")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.TechCheckProcedure, robotName);
        }

        public string Work(string robotName, int procedureTime)
        {
            RobotExists(robotName);
            procedures.First(procedure => procedure.GetType().Name.Equals("Work")).DoService(Garage.Robots[robotName], procedureTime);
            return string.Format(OutputMessages.WorkProcedure, robotName, procedureTime);
        }
    }
}
