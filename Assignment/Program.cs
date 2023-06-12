using Assignment.InterfaceCommand;

namespace Assignment
{
    public static class Program
    {
        // Define the available commands as an enum
        enum Commands
        {
            on,
            off,
            north,
            south,
            east,
            west
        }

        // Assigns the appropriate command to the robot based on the input string
        public static bool AssignCommand(Robot robot, string? command)
        {
            if (Enum.TryParse<Commands>(command, out Commands thisCommand))
            {
                // Use switch expression to load the command based on the enum value
                robot.LoadCommand(thisCommand switch
                {
                    Commands.on => new OnCommand(),
                    Commands.off => new OffCommand(),
                    Commands.north => new NorthCommand(),
                    Commands.south => new SouthCommand(),
                    Commands.east => new EastCommand(),
                    Commands.west => new WestCommand(),
                    _ => throw new ArgumentOutOfRangeException()
                });

                return true;
            }
            else
            {
                // Display error message for invalid command
                Console.WriteLine("command not valid - Please try again");
                return false;
            }
        }

        static void Main()
        {
            // Run your RobotTester class here -> RobotTester.TestRobot()

            // Create a new robot instance
            Robot newRobot = new();

            Console.WriteLine("choose 6 possible commands for robot:");

            // Print all command names
            foreach (string command in Enum.GetNames(typeof(Commands)))
            {
                Console.WriteLine(command);
            }

            // Get 6 commands from the user and assign them to the robot
            for (int input = 0; input < 6; input++)
            {
                Console.Write($"Assign command #{input + 1}: ");
                bool commandAdded = AssignCommand(newRobot, Console.ReadLine());
                if (!commandAdded)
                {
                    // Decrement input index if command was not added successfully
                    input--;
                }
            }

            // Run the robot to execute the assigned commands
            newRobot.Run();
        }
    }
}
