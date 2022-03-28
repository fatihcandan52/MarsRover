using System;
using System.Text.RegularExpressions;

namespace MarsRover.ConsoleApp
{
    public class MoveCommand : Command
    {
        public override Regex RegexCommandPattern => new Regex("^[LRM]+$");

        public override void Run(string command)
        {
            if (MarsContext.Instance.ActivePlateau == null)
                throw new ArgumentNullException("ActivePlateau is not null");

            if (MarsContext.Instance.ActivePlateau.ActiveVehicle == null)
                throw new ArgumentNullException("ActiveVehicle is not null");

            MarsContext.Instance.ActivePlateau.ActiveVehicle.Movement(command.ToVehicleMovements());

            if (MarsContext.Instance.ActivePlateau == null || MarsContext.Instance.ActivePlateau.PlateauSize == null)
                throw new ArgumentNullException("ActivePlateau or PlateauSize is not null");

            if (MarsContext.Instance.ActivePlateau.PlateauSize.PlateauX < MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.X ||
                MarsContext.Instance.ActivePlateau.PlateauSize.PlateauY < MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.Y ||
                MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.X < 0 ||
                MarsContext.Instance.ActivePlateau.ActiveVehicle.Position.Y < 0)
            {
                throw new Exception("Vehicle moved to out of plateau");
            }
        }
    }
}
