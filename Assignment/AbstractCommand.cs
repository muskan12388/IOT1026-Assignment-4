namespace Assignment.AbstractCommand
{
    // Base class for all robot commands
    public abstract class RobotCommand
    {
        // Method to be implemented by derived classes
        public abstract void Run(Robot robot);
    }

    // Command to turn the robot off
    public class OffCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = false;
    }

    // Command to turn the robot on
    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot) => robot.IsPowered = true;
    }

    // Command to move the robot to the west
    public class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X--;
            }
        }
    }

    // Command to move the robot to the east
    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X++;
            }
        }
    }

    // Command to move the robot to the south
    public class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y--;
            }
        }
    }

    // Command to move the robot to the north
    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y++;
            }
        }
    }
}
