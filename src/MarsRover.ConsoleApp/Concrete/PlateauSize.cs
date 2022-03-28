using System;

namespace MarsRover.ConsoleApp
{
    public class PlateauSize : IPlateauSize
    {
        public int PlateauX { get; set; }
        public int PlateauY { get; set; }

        public PlateauSize(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentException("Invalid argument");

            if (x == 0 && y == 0)
                throw new ArgumentException("Invalid argument");

            PlateauX = x;
            PlateauY = y;
        }
    }
}
