using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected readonly List<IRobot> robots;
        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if(robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }
            robot.ProcedureTime -= procedureTime;
            robots.Add(robot);
        }

        public string History()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.GetType().Name);
            foreach(var robot in robots)
            {
                result.AppendLine(robot.ToString());
            }
            return result.ToString().TrimEnd();
        }

        public Procedure()
        {
            this.robots = new List<IRobot>();
        }
    }
}
