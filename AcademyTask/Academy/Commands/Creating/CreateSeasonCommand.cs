using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Creating
{
    public class CreateSeasonCommand : CreateCommand
    {
        public CreateSeasonCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var startingYear = args[0];
            var endingYear = args[1];
            var initiative = args[2];

            this.Seasons.Add(this.Factory.CreateSeason(startingYear, endingYear, initiative));

            return $"Season with ID {this.Seasons.Count - 1} was created.";
        }
    }
}
