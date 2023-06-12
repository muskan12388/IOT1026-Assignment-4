namespace Assignment.InterfaceCommand
{
    public interface RobotCommand
    {
        void Run(Robot robot); // Interfaces are public and abstract by default.
    }

    public class OffCommand : RobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = false;
    }

    public class OnCommand : RobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = true;
    }

    public class WestCommand : RobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X--;
            }
            else
            {
                // Handle the case when the robot is not powered.
                // Add your code here.
            }
        }
    }

    public class EastCommand : RobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.X++;
            }
            else
            {
                // Handle the case when the robot is not powered.
                // Add your code here.
            }
        }
    }

    public class SouthCommand : RobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y--;
            }
            else
            {
                // Handle the case when the robot is not powered.
                // Add your code here.
            }
        }
    }

    public class NorthCommand : RobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y++;
            }
            else
            {
                // Handle the case when the robot is not powered.
                // Add your code here.
            }
        }
    }

    public class BachataCommand : RobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                for (int repeatSteps = 0; repeatSteps < 3; repeatSteps++)
                {
                    robot.X++;
                    robot.X++;
                    robot.X--;
                    robot.X--;
                    robot.X--;
                }
                robot.Y++;
                robot.X--;
                robot.Y--;
                robot.X++;
            }
            else
            {
                // Handle the case when the robot is not powered.
                // Add your code here.
            }
        }
    }
}
