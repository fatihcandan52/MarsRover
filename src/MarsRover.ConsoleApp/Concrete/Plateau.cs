using System.Collections.Generic;

namespace MarsRover.ConsoleApp
{
    public class Plateau
    {
        public Plateau(IPlateauSize positionSize)
        {
            PlateauSize = positionSize;
            VehicleList = new List<IVehicle>();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            VehicleList.Add(vehicle);
            ActiveVehicle = vehicle;
        }

        public IPlateauSize PlateauSize { get; set; }
        public List<IVehicle> VehicleList { get; set; }
        public IVehicle ActiveVehicle { get; set; }
    }
}
