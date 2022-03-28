using MarsRover.ConsoleApp;
using NUnit.Framework;
using System;

namespace MarsRover.UnitTests
{
    public class PlatoueSizeTests
    {
        [Test]
        [TestCase(12, 9)]
        public void Create_Platou_When_X_12_Y_9_Succeed_Test(int x, int y)
        {
            var size = new PlateauSize(x, y);
            Assert.NotNull(size);
        }

        [Test]
        [TestCase(-5, 9)]
        public void Create_Plateou_When_Negative_X_5_Y_9_Failed_Test(int x, int y)
        {
            Assert.Throws<ArgumentException>(() => new PlateauSize(x, y));
        }

        [Test]
        [TestCase(5, -9)]
        public void Create_Plateou_When_X_5_Negative_Y_9_Failed_Test(int x, int y)
        {
            Assert.Throws<ArgumentException>(() => new PlateauSize(x, y));
        }

        [Test]
        [TestCase(0, 0)]
        public void Create_Platou_When_Zero_X_Zero_Y_Failed_Test(int x, int y)
        {
            Assert.Throws<ArgumentException>(() => new PlateauSize(x, y));
        }
    }
}
