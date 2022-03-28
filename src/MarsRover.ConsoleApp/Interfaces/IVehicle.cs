using System.Collections.Generic;

namespace MarsRover.ConsoleApp
{
    public interface IVehicle
    {
        Position Position { get; set; }
        string GetPosition();
        void Movement(List<VehicleMovementEnum> vehicleMovements);
    }
}
