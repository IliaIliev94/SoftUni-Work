using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IGarage garage;
        private List<Procedure> procedures = new List<Procedure>()
        {
            new Chip(),
            new Charge(),
            new Polish(),
            new Rest(),
            new TechCheck(),
            new Work()
        };
        private List<string> robotTypes = new List<string>
        {
            "HouseholdRobot",
            "PetRobot",
            "WalkerRobot"
        };
        public string Charge(string robotName, int procedureTime)
        {
            IRobot robot = FindRobot(robotName);
            FindProcedure("Charge").DoService(robot, procedureTime);
            return String.Format(OutputMessages.ChargeProcedure, robotName);
        }

        public string Chip(string robotName, int procedureTime)
        {

            IRobot robot = FindRobot(robotName);
            FindProcedure("Chip").DoService(robot, procedureTime);
            return String.Format(OutputMessages.ChipProcedure, robotName);
        }

        public string History(string procedureType)
        {
            return FindProcedure(procedureType).History();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            if(!robotTypes.Contains(robotType))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidRobotType, robotType));
            }
            IRobot robot = null;
            switch(robotType)
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
            garage.Manufacture(robot);
            return String.Format(OutputMessages.RobotManufactured, name);
        }

        public string Polish(string robotName, int procedureTime)
        {
            IRobot robot = FindRobot(robotName);
            FindProcedure("Polish").DoService(robot, procedureTime);
            return String.Format(OutputMessages.PolishProcedure, robotName);
        }

        public string Rest(string robotName, int procedureTime)
        {
            IRobot robot = FindRobot(robotName);
            FindProcedure("Rest").DoService(robot, procedureTime);
            return String.Format(OutputMessages.RestProcedure, robotName);
        }

        public string Sell(string robotName, string ownerName)
        {
            
            IRobot robot = null;
            if (garage.Robots.ContainsKey(robotName))
            {
                robot = FindRobot(robotName);
            }
            garage.Sell(robotName, ownerName);
            if(robot.IsChipped)
            {
                return String.Format(OutputMessages.SellChippedRobot, ownerName);
            }
            return String.Format(OutputMessages.SellNotChippedRobot, ownerName);
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            IRobot robot = FindRobot(robotName);
            FindProcedure("TechCheck").DoService(robot, procedureTime);
            return String.Format(OutputMessages.TechCheckProcedure, robotName);
        }

        public string Work(string robotName, int procedureTime)
        {
            IRobot robot = FindRobot(robotName);
            FindProcedure("Work").DoService(robot, procedureTime);
            return String.Format(OutputMessages.WorkProcedure, robotName, procedureTime);
        }

        private Procedure FindProcedure(string procedureName)
        {
            return procedures.FirstOrDefault(procedure => procedure.GetType().Name.Equals(procedureName));
        }

        private IRobot FindRobot(string robotName)
        {
            if(!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            return garage.Robots[robotName];
        }

        public Controller()
        {
            garage = new Garage();
        }
    }
}
