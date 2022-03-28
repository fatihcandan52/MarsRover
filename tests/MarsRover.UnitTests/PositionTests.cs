using MarsRover.ConsoleApp;
using NUnit.Framework;
using System;

namespace MarsRover.UnitTests
{
    public class PositionTests
    {
        [Test]
        [TestCase(12, 9, RoverDirectionEnum.E)]
        public void Create_Position_When_X_12_Y_9_RoverDirection_E_Succeed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            Assert.NotNull(position);
        }

        [Test]
        [TestCase(12, 9, RoverDirectionEnum.S)]
        public void Create_Position_When_X_12_Y_9_RoverDirection_S_Succeed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            Assert.NotNull(position);
        }

        [Test]
        [TestCase(12, 9, RoverDirectionEnum.W)]
        public void Create_Position_When_X_12_Y_9_RoverDirection_W_Succeed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            Assert.NotNull(position);
        }

        [Test]
        [TestCase(12, 9, RoverDirectionEnum.N)]
        public void Create_Position_When_X_12_Y_9_RoverDirection_N_Succeed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            Assert.NotNull(position);
        }

        [Test]
        [TestCase(-5, 9, RoverDirectionEnum.W)]
        public void Create_Position_When_Negative_5_X__Y_9_RoverDirection_W_Failed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            Assert.Throws<ArgumentException>(() => new Position(x, y, roverDirection));
        }

        [Test]
        [TestCase(5, -9, RoverDirectionEnum.N)]
        public void Create_Position_When_5_X_Negative_Y_9_RoverDirection_W_Failed_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            Assert.Throws<ArgumentException>(() => new Position(x, y, roverDirection));
        }
    }
}
