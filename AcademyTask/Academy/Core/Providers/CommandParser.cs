using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Academy.Core.Providers
{
    public class CommandParser : IParser
    {
        private readonly IAcademyFactory factory;
        private readonly IDataManager dataManager;

        public CommandParser(IAcademyFactory factory, IDataManager dataManager)
        {
            this.factory = factory;
            this.dataManager = dataManager;
        }

        // Magic, do not touch!

        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split(' ')[0];
            var commandTypeInfo = this.FindCommand(commandName);

            //If command is Create pass factory else dont
            ICommand command;
            if (commandName.StartsWith("Create"))
            {
                var commandBase = Activator.CreateInstance(commandTypeInfo, this.factory, this.dataManager) as ICommand;
                command = Activator.CreateInstance(this.FindCommand("DateTimeDecorator"), commandBase) as ICommand;
            }
            else
            {
                command = Activator.CreateInstance(commandTypeInfo, this.dataManager) as ICommand;
            }

            return command;
        }

        // Magic, do not touch!
        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split(' ').Skip(1).ToList();

            if (commandParts.Count() == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }

        // Very magic, do not even think about touching!!!
        private TypeInfo FindCommand(string commandName)
        {
            Assembly currentAssembly = this.GetType().GetTypeInfo().Assembly;
            var commandTypeInfo = currentAssembly.DefinedTypes
                .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                .Where(type => type.Name.ToLower() == (commandName.ToLower() + "command"))
                .SingleOrDefault();

            if (commandTypeInfo == null)
            {
                throw new ArgumentException("The passed command is not found!");
            }

            return commandTypeInfo;
        }
    }
}