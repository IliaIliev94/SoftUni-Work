using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        public TechCheck() : base()
        {

        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            robot.Energy -= 8;
            if(robot.IsChecked)
            {
                robot.Energy -= 8;
            }
            else
            {
                robot.IsChecked = true;
            }
        }
    }
}
