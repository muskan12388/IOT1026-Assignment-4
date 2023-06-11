using Assignment.InterfaceCommand;

namespace Assignment
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }


    public class Robot
    {
        public bool IsPlaced { get; set; }
        // Define public properties
        public int NumCommands { get; } // Represents the number of commands the robot can store
        public int X { get; set; } // Represents the X coordinate of the robot's position
        public int Y { get; set; } // Represents the Y coordinate of the robot's position
        public bool IsPowered { get; set; } // Indicates whether the robot is powered on or off

        // Define private fields
        private const int DefaultCommands = 6; // Default number of commands the robot can store
        private readonly IRobotCommand[] _commands; // Array to store the robot commands
        private int _commandsLoaded = 0; // Counter to track the number of commands loaded into the robot

        // Override the ToString() method to provide a string representation of the robot's state
        public override string ToString()
        {
            return $"[{X} {Y} {IsPowered}]";
        }

        // Default constructor that initializes the robot with the default number of commands
        public Robot() : this(DefaultCommands) { }

        // Constructor that allows specifying the number of commands the robot can store
        public Robot(int numCommands)
        {
            _commands = new IRobotCommand[numCommands];
            NumCommands = numCommands;
        }

        // Method to run the loaded commands
        public void Run()
        {
            for (var i = 0; i < _commandsLoaded; ++i)
            {
                _commands[i].Run(this);
                Console.WriteLine(this);
            }
        }

        // Method to load a command into the robot
        public bool LoadCommand(IRobotCommand command)
        {
            if (_commandsLoaded >= NumCommands)
                return false;
            _commands[_commandsLoaded++] = command;
            return true;
        }
    }
}
