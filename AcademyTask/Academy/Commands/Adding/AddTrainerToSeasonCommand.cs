using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Adding
{
    public class AddTrainerToSeasonCommand : Command
    {
        public AddTrainerToSeasonCommand(IDataManager dataManager) : base(dataManager) { }

        public override string Execute(IList<string> args)
        {
            var username = args[0].ToLower();
            var seasonId = int.Parse(args[1]);

            var trainer = this.Trainers.First(x => x.Username.ToLower() == username);
            var season = this.Seasons[seasonId];

            if (season.Trainers.Contains(trainer))
            {
                throw new ArgumentException($"The Trainer {username} is already a part of Season {seasonId}!");
            }

            season.Trainers.Add(trainer);
            return $"Trainer {args[0]} was assigned to Season {seasonId}.";
        }
    }
}
