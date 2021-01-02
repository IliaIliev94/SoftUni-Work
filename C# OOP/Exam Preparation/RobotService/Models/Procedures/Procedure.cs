using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected IList<IRobot> robots;
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
            for(int i = 0; i < this.robots.Count; i++)
            {
                if(i != robots.Count - 1)
                {
                    result.AppendLine(robots[i].ToString());
                }
                else
                {
                    result.Append(robots[i].ToString());
                }
            }
            return result.ToString();
        }

        protected Procedure()
        {
            this.robots = new List<IRobot>();
        }
    }
}
