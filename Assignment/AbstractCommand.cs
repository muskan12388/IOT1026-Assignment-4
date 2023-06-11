using System;
using Assignment.InterfaceCommand;

namespace Assignment
{
    public abstract class RobotCommand : IRobotCommand
    {
        public abstract void Run(Robot robot);
    }

    // Existing command classes
    public class OffCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = false;
    }

    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = true;
    }

    public class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X--;
        }
    }

    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.X += robot.IsPlaced ? 1 : 0;
        }
    }

    public class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.Y--;
        }
    }

    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
                robot.Y++;
        }
    }
}
