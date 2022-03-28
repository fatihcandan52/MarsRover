using System;
using System.Text.RegularExpressions;

namespace MarsRover.ConsoleApp
{
    public class AddVehicleWithPositonCommand : Command
    {
        public override Regex RegexCommandPattern => new Regex("^\\d+ \\d+ [ESWN]$");

        public override void Run(string command)
        {
            if (MarsContext.Instance.ActivePlateau == null)
                throw new ArgumentNullException("ActivePlateau is not null");

            var splitPosition = command.Split(" ");

            int x = splitPosition[0].ToInt32();
            int y = splitPosition[1].ToInt32();
            RoverDirectionEnum roverDirection = splitPosition[2].ToRoverDirection();

            var position = new Position(x, y, roverDirection);
            var vehicle = new Rover(position);

            MarsContext.Instance.ActivePlateau.AddVehicle(vehicle);

            if (MarsContext.Instance.ActivePlateau.PlateauSize.PlateauX < MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.X ||
                MarsContext.Instance.ActivePlateau.PlateauSize.PlateauY < MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.Y ||
                MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.X < 0 ||
                MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.Y < 0)
            {
                throw new Exception("Vehicle left off plateau");
            }

        }
    }
}
