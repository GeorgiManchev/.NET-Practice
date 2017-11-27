using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Creating
{
    public class CreateCourseCommand : CreateCommand
    {
        public CreateCourseCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var seasonId = int.Parse(args[0]);

            var season = this.Seasons[seasonId];
            var course = this.Factory.CreateCourse(args[1], args[2], args[3]);

            season.Courses.Add(course);

            return $"Course with ID {season.Courses.Count - 1} was created in Season {seasonId}.";
        }
    }
}
