using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Listing
{
    public class ListCoursesInSeasonCommand : Command
    {
        public ListCoursesInSeasonCommand(IDataManager manager) : base(manager) { }

        public override string Execute(IList<string> args)
        {
            var seasonId = int.Parse(args[0]);
            var season = this.Seasons[seasonId];

            if (season.Courses.Count == 0)
            {
                return "There are no courses in this season!";
            }

            return string.Join("\n", season.Courses);
        }
    }
}
