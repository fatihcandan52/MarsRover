using MarsRover.ConsoleApp;
using NUnit.Framework;
using System;

namespace MarsRover.UnitTests
{
    public class CommandCenterTests
    {
        [Test]
        [TestCase(new object[] { "5 5", "1 2 N", "LMLMLMLMM", "1 3 N" })]
        [TestCase(new object[] { "5 5", "3 3 E", "MMRMMRMRRM", "5 1 E" })]
        public void Command_Center_Succeed_Test(string command1, string command2, string command3, string vehiclePosition)
        {
            var commandCenter = new CommandCenter();
            commandCenter.SendCommand(command1);
            commandCenter.SendCommand(command2);
            commandCenter.SendCommand(command3);

            var context = commandCenter.GetContext();
            Assert.AreEqual(context.ActivePlateau.ActiveVehicle.GetPosition(), vehiclePosition);
        }


        [Test]
        [TestCase(new object[] { "10 5", "6 2 N", "LMLMLMLMM", "1 6 N" })]
        [TestCase(new object[] { "5 12", "1 3 W", "RMRMMRMRRM", "5 7 E" })]
        [TestCase(new object[] { "12 15", "5 4 S", "MMRMMLMRRM", "3 7 E" })]
        [TestCase(new object[] { "10 12", "3 3 E", "LMRRMRMRRM", "5 5 E" })]
        public void Command_Center_Failed_Test(string command1, string command2, string command3, string vehiclePosition)
        {
            var commandCenter = new CommandCenter();

            commandCenter.SendCommand(command1);
            commandCenter.SendCommand(command2);
            commandCenter.SendCommand(command3);

            var context = commandCenter.GetContext();
            Assert.AreNotEqual(context.ActivePlateau.ActiveVehicle.GetPosition(), vehiclePosition);
        }

        [Test]
        [TestCase(new object[] { "10 10", "12 2 N", "LMLMLMLMM"})]
        public void Rover_Left_Off_Plateau_Test(string command1, string command2, string command3)
        {
            var commandCenter = new CommandCenter();
            commandCenter.SendCommand(command1);

            Assert.Throws<Exception>(() => commandCenter.SendCommand(command2));
        }

        [Test]
        [TestCase(new object[] { "10 10", "8 2 N", "RMMMLMLMLMLMM" })]
        public void Rover_Move_To_Out_Of_Plateau_Test(string command1, string command2, string command3)
        {
            var commandCenter = new CommandCenter();
            commandCenter.SendCommand(command1);
            commandCenter.SendCommand(command2);

            Assert.Throws<Exception>(() => commandCenter.SendCommand(command3));
        }
    }
}
