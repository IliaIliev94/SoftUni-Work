using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            int removeEnergy = 8;
            if(robot.IsChecked)
            {
                removeEnergy *= 2;
            }
            robot.Energy -= removeEnergy;
        }
    }
}
