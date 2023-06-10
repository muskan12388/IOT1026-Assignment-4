namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            RobotTester tester = new RobotTester();
            object value = tester.TestRobot();

            Console.ReadLine();
        }

        private class RobotTester
        {
            internal object TestRobot()
            {
                throw new NotImplementedException();
            }
        }
    }

}