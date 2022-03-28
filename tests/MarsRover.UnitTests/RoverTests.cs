using MarsRover.ConsoleApp;
using NUnit.Framework;

namespace MarsRover.UnitTests
{
    public class RoverTests
    {
        [Test]
        [TestCase(0, 0, RoverDirectionEnum.N)]
        public void Rover_Moving_Turn_Left_When_Direction_N_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnLeft();
            Assert.AreEqual("W", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.N)]
        public void Rover_Moving_Turn_Right_When_Direction_N_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnRight();
            Assert.AreEqual("E", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.E)]
        public void Rover_Moving_Turn_Left_When_Direction_E_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnLeft();
            Assert.AreEqual("N", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.E)]
        public void Rover_Moving_Turn_Right_When_Direction_E_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnRight();
            Assert.AreEqual("S", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.S)]
        public void Rover_Moving_Turn_Left_When_Direction_S_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnLeft();
            Assert.AreEqual("E", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.S)]
        public void Rover_Moving_Turn_Right_When_Direction_S_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnRight();
            Assert.AreEqual("W", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.W)]
        public void Rover_Moving_Turn_Left_When_Direction_W_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnLeft();
            Assert.AreEqual("S", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(0, 0, RoverDirectionEnum.W)]
        public void Rover_Moving_Turn_Right_When_Direction_W_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.TurnRight();
            Assert.AreEqual("N", rover.Position.Direction.ToString());
        }

        [Test]
        [TestCase(5, 5, RoverDirectionEnum.N)]
        public void Rover_Moving_Move_To_North_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.Move();

            Assert.AreEqual("6", rover.Position.Y.ToString());
        }

        [Test]
        [TestCase(5, 5, RoverDirectionEnum.E)]
        public void Rover_Moving_Move_To_East_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.Move();

            Assert.AreEqual("6", rover.Position.X.ToString());
        }

        [Test]
        [TestCase(5, 5, RoverDirectionEnum.S)]
        public void Rover_Moving_Move_To_South_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.Move();

            Assert.AreEqual("4", rover.Position.Y.ToString());
        }

        [Test]
        [TestCase(5, 5, RoverDirectionEnum.W)]
        public void Rover_Moving_Move_To_West_Test(int x, int y, RoverDirectionEnum roverDirection)
        {
            var position = new Position(x, y, roverDirection);
            var rover = new Rover(position);
            rover.Move();

            Assert.AreEqual("4", rover.Position.X.ToString());
        }
    }
}
