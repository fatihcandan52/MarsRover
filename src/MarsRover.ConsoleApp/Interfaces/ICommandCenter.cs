namespace MarsRover.ConsoleApp
{
    public interface ICommandCenter
    {
        void SendCommand(string command);
        void PrintAllVehiclePosition();
    }
}
