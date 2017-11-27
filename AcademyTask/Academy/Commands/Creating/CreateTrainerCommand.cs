using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Creating
{
    public class CreateTrainerCommand : CreateCommand
    {
        public CreateTrainerCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var name = args[0].ToLower();
            var technologies = args[1];

            if (this.Students.Select(x => x.Username.ToLower()).Any(x => x == name) ||
                this.Trainers.Select(x => x.Username.ToLower()).Any(x => x == name))
            {
                throw new ArgumentException($"A user with the username {name} already exists!");
            }

            this.Trainers.Add(this.Factory.CreateTrainer(name, technologies));

            return $"Trainer with ID {this.Trainers.Count - 1} was created.";
        }
    }
}
