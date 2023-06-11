namespace Assignment.InterfaceCommand
{
    // Define an interface for robot commands
    public interface IRobotCommand
    {
        void Run(Robot robot);
    }

    // Define a custom command that implements the IRobotCommand interface
    public class CustomCommand : IRobotCommand
    {
        // Implement the Run method to perform custom actions on the robot
        public void Run(Robot robot)
        {
            // Perform your custom action on the robot here
            // For example:
            robot.X += 5; // Increase the X coordinate of the robot's position by 5
            robot.Y -= 3; // Decrease the Y coordinate of the robot's position by 3
            robot.IsPowered = true; // Set the IsPowered property of the robot to true
        }

    }
}
