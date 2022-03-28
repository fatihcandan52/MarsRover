using System.Text.RegularExpressions;

namespace MarsRover.ConsoleApp
{
    public abstract class Command : ICommand
    {
        public abstract Regex RegexCommandPattern { get; }

        public abstract void Run(string command);

        public bool IsMatch(string command)
        {
            return RegexCommandPattern.IsMatch(command);
        }
    }
}
