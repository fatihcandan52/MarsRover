using System;
using System.Text.RegularExpressions;

namespace MarsRover.ConsoleApp
{
    public class AddPlateauCommand : Command
    {
        public override Regex RegexCommandPattern => new Regex("^\\d+ \\d+$");

        public override void Run(string command)
        {
            var splitPosition = command.Split(" ");

            int x = splitPosition[0].ToInt32();
            int y = splitPosition[1].ToInt32();

            MarsContext.Instance.AddPlatoue(x, y);
        }
    }
}
