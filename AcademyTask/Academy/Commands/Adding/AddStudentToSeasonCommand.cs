using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Adding
{
    public class AddStudentToSeasonCommand : Command
    {
        public AddStudentToSeasonCommand(IDataManager dataManager) : base(dataManager) { }

        public override string Execute(IList<string> args)
        {
            var username = args[0].ToLower();
            var seasonId = int.Parse(args[1]);

            var student = this.Students.First(x => x.Username.ToLower() == username);
            var season = this.Seasons[seasonId];

            if (season.Students.Contains(student))
            {
                throw new ArgumentException($"The Student {username} is already a part of Season {seasonId}!");
            }

            season.Students.Add(student);
            return $"Student {args[0]} was added to Season {seasonId}.";
        }
    }
}
