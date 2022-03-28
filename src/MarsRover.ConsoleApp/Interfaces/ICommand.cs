using System.Text.RegularExpressions;

namespace MarsRover.ConsoleApp
{
    public interface ICommand
    {
        Regex RegexCommandPattern { get; }

        void Run(string command);

        bool IsMatch(string command);
    }
}
