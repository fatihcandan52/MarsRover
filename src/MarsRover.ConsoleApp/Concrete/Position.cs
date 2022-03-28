using System;

namespace MarsRover.ConsoleApp
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public RoverDirectionEnum Direction { get; set; }

        public Position(int x, int y, RoverDirectionEnum roverDirection)
        {
            if (x < 0 || y < 0)
                throw new ArgumentException("Invalid argument");

            X = x;
            Y = y;
            Direction = roverDirection;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction.ToString()}";
        }
    }
}
