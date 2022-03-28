using MarsRover.ConsoleApp;
using NUnit.Framework;
using System;
using System.Linq;

namespace MarsRover.UnitTests
{
    public class CommandTests
    {
        [Test]
        [TestCase(new object[] { "5 5"})]
        public void Add_Plateau_Command_Pattern_Check_Success(string command)
        {
            var commands = CommandFactory.Instance.Commands;
            var currentCommand = commands.SingleOrDefault(x => x.IsMatch(command));

            Assert.AreEqual(currentCommand.RegexCommandPattern.ToString(), "^\\d+ \\d+$");
        }

        [Test]
        [TestCase(new object[] { "1 2 N" })]
        public void Add_Vehicle_With_Positon_Command_Pattern_Check_Success(string command)
        {
            var commands = CommandFactory.Instance.Commands;
            var currentCommand = commands.SingleOrDefault(x => x.IsMatch(command));

            Assert.AreEqual(currentCommand.RegexCommandPattern.ToString(), "^\\d+ \\d+ [ESWN]$");
        }

        [Test]
        [TestCase(new object[] { "LMLMLMLMM" })]
        public void Move_Command_Pattern_Check_Success(string command)
        {
            var commands = CommandFactory.Instance.Commands;
            var currentCommand = commands.SingleOrDefault(x => x.IsMatch(command));

            Assert.AreEqual(currentCommand.RegexCommandPattern.ToString(), "^[LRM]+$");
        }

        [Test]
        [TestCase(new object[] { "5 5 5 5 E" })]
        public void Command_Pattern_Check_Failed(string command)
        {
            var commandCenter = new CommandCenter();
            Assert.Throws<Exception>(() => commandCenter.SendCommand(command));
        }
    }
}
