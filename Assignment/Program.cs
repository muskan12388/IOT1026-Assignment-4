using System;
using Assignment.InterfaceCommand;

namespace Assignment
{
    // Import the required namespace(s) for the code to work


    public class RobotTester
    {
        // Method to test robot commands
        public void TestRobotCommands(IRobotCommand? command)
        {
            Robot robot = new Robot(); // Create a new instance of the Robot class
            string? commandString;

            while (true)
            {
                Console.WriteLine("Enter a command ('exit' to quit):");
                commandString = Console.ReadLine();

                if (string.Equals(commandString, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                IRobotCommand? robotCommand = ConvertToCommand(commandString);
                if (command != null) // Check if a valid command was obtained
                {
                    robot.LoadCommand(command); // Load the command into the robot
                    robot.Run(); // Run the loaded commands
                    Console.WriteLine(robot.ToString()); // Display the current state of the robot
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again."); // Inform the user that an invalid command was entered
                }
            }
        }

        // Method to convert a string command to a corresponding robot command object
        private IRobotCommand? ConvertToCommand(string? commandString)
        {
            if (string.IsNullOrEmpty(commandString))
                return null;

            switch (commandString.ToLower()) // Convert the command string to lowercase for case-insensitive comparison
            {
                case "on":
                    return new OnCommand(); // Return an instance of the OnCommand class
                case "off":
                    return new OffCommand(); // Return an instance of the OffCommand class
                case "north":
                    return new NorthCommand(); // Return an instance of the NorthCommand class
                case "south":
                    return new SouthCommand(); // Return an instance of the SouthCommand class
                case "east":
                    return new EastCommand(); // Return an instance of the EastCommand class
                case "west":
                    return new WestCommand(); // Return an instance of the WestCommand class
                default:
                    return null; // Return null if the command string is not recognized
            }
        }

        internal void TestRobotCommands(object robotCommand)
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        private static IRobotCommand? robotCommand;

        static void Main(string[] args)
        {
            RobotTester robotTester = new RobotTester(); // Create a new instance of the RobotTester class
            robotTester.TestRobotCommands(robotCommand); // Invoke the method to test robot commands

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for a key press before exiting the program
        }
    }
}
