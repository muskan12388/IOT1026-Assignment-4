using Assignment;
using Assignment.InterfaceCommand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void PropertiesTest()
        {
            // ... existing assertions for Robot class properties
        }

        [TestMethod]
        public void TestOnCommand()
        {
            // Arrange
            Robot robot = new Robot();
            IRobotCommand command = new OnCommand();

            // Act
            robot.LoadCommand(command);
            robot.Run();

            // Assert
            Assert.IsTrue(robot.IsPowered);
        }

        [TestMethod]
        public void TestOffCommand()
        {
            // Arrange
            Robot robot = new Robot();
            IRobotCommand command = new OffCommand();

            // Act
            robot.LoadCommand(command);
            robot.Run();

            // Assert
            Assert.IsFalse(robot.IsPowered);
        }

        // Add more test methods for other command classes (e.g., WestCommand, EastCommand, etc.)

        [TestMethod]
        public void TestCustomCommand()
        {
            // Arrange
            Robot robot = new Robot();
            IRobotCommand command = new CustomCommand();

            // Act
            robot.LoadCommand(command);
            robot.Run();

            // Assert
            // Add assertions to verify the expected behavior of the custom command
        }

        
        
        
    }
}