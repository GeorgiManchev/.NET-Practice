using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersInSeasonCommand : Command
    {
        public ListUsersInSeasonCommand(IDataManager manager) : base(manager) { }

        public override string Execute(IList<string> args)
        {
            var seasonId = int.Parse(args[0]);
            var season = this.Seasons[seasonId];

            if (season.Trainers.Count == 0 && season.Students.Count == 0)
            {
                return "There are no users in this season!";
            }

            var result = new StringBuilder();
            result.AppendLine(string.Join("\n", season.Trainers));
            result.AppendLine(string.Join("\n", season.Students));

            return result.ToString();
        }
    }
}
