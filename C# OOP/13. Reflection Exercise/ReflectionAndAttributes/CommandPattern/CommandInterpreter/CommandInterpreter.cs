using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace CommandPattern
{
    class CommandInterpreter : ICommandInterpreter
    {
        private List<ICommand> commands = new List<ICommand>()
        {
            new HelloCommand(),
            new ExitCommand()
        };
        public string Read(string args)
        {
            string[] data = args.Split();
            string commandType = data[0] + "Command";
            Type type = Assembly.GetCallingAssembly()
                .GetTypes().First(command => command.Name.Equals(commandType));
            ICommand command = (ICommand)Activator.CreateInstance(type);
            string[] arguments = new string[data.Length - 1];
            Array.Copy(data, 1, arguments, 0, data.Length - 1);
            return command.Execute(arguments);
        }
    }
}
