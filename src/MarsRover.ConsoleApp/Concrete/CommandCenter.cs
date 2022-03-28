using System;
using System.Linq;

namespace MarsRover.ConsoleApp
{
    public class CommandCenter : ICommandCenter
    {
        public void SendCommand(string command)
        {
            var commands = CommandFactory.Instance.Commands;
            var currentCommand = commands.SingleOrDefault(x => x.IsMatch(command));

            if (currentCommand == null)
                throw new Exception("Uncnown command");

            currentCommand.Run(command);
        }

        public void PrintAllVehiclePosition()
        {
            var context = this.GetContext();
            foreach (var plateau in context.PlateauList)
            {
                foreach (var item in plateau.VehicleList)
                {
                    Console.WriteLine(item.GetPosition());
                }
            }
        }

        public MarsContext GetContext()
        {
            return MarsContext.Instance;
        }
    }
}
