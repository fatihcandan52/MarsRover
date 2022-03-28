using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.ConsoleApp
{
    public class CommandFactory
    {
        private static CommandFactory instance = null;
        private static readonly object padlock = new object();

        private CommandFactory()
        {
            Commands = typeof(Command).Assembly.DefinedTypes
               .Where(type => type.IsSubclassOf(typeof(Command)) && !type.IsAbstract)
               .Select(x => Activator.CreateInstance(x) as Command)
               .ToList();
        }

        public static CommandFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CommandFactory();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Command> Commands;
    }
}
