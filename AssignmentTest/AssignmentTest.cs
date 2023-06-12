using Assignment;
using Assignment.AbstractCommand;

internal class Program
{
    private static void Main(string[] args)
    {
        // Main method implementation
    }

    [TestMethod]
    private static void TestAssignCommand()
    {
        Robot robot = new(); // Create a new Robot object
        string[] validCommands = { "on", "off", "north", "south", "east", "west" };

        bool result = true; // Initialize the result variable as true
        foreach (string command in validCommands)
        {
            RobotCommand? robotCommand; // Declare a nullable RobotCommand variable
            switch (command.ToLower()) // Check the lowercase command value
            {
                case "on":
                    robotCommand = new OnCommand(); // Create a new OnCommand object
                    break;
                case "off":
                    robotCommand = new OffCommand(); // Create a new OffCommand object
                    break;
                case "north":
                    robotCommand = new NorthCommand(); // Create a new NorthCommand object
                    break;
                case "south":
                    robotCommand = new SouthCommand(); // Create a new SouthCommand object
                    break;
                case "east":
                    robotCommand = new EastCommand(); // Create a new EastCommand object
                    break;
                case "west":
                    robotCommand = new WestCommand(); // Create a new WestCommand object
                    break;
                default:
                    robotCommand = null; // Set the robotCommand as null for invalid commands
                    break;
            }

            result &= robotCommand != null; // Check if robotCommand is not null and update the result
            if (robotCommand != null)
            {
                robot.LoadCommand(robotCommand: robotCommand); // Load the robotCommand into the robot
            }
        }

        Assert.AreEqual(result, true); // Check if the result is true using the Assert class
    }
}
