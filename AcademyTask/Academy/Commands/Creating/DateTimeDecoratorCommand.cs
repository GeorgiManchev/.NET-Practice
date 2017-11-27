using Academy.Commands.Contracts;
using System;
using System.Collections.Generic;

namespace Academy.Commands.Creating
{
    public class DateTimeDecoratorCommand : ICommand
    {
        private readonly ICommand command;

        public DateTimeDecoratorCommand(ICommand command)
        {
            this.command = command;
        }

        public string Execute(IList<string> args)
        {
            return $"Command is called at {DateTime.Now}!\n{this.command.Execute(args)}";
        }
    }
}
