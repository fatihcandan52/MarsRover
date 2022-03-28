using System;
using Microsoft.Extensions.DependencyInjection;


namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mars!");

            var serviceProvider = ServiceCollectionInit.ConfigureServices();
            var commandCenter = serviceProvider.GetService<ICommandCenter>();

            commandCenter.SendCommand("5 5");
            commandCenter.SendCommand("1 2 N");
            commandCenter.SendCommand("LMLMLMLMM");
            //output: 1 3 N

            commandCenter.SendCommand("3 3 E");
            commandCenter.SendCommand("MMRMMRMRRM");
            //output: 5 1 E

            commandCenter.SendCommand("10 10");
            commandCenter.SendCommand("5 3 S");
            commandCenter.SendCommand("MMRMLRMLMRM");
            //output 2 0 W

            commandCenter.PrintAllVehiclePosition();
            Console.ReadKey();
        }
    }
}
