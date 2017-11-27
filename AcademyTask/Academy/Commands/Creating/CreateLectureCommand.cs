using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Creating
{
    public class CreateLectureCommand : CreateCommand
    {
        public CreateLectureCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var seasonId = int.Parse(args[0]);
            var courseId = int.Parse(args[1]);
            var username = args[4].ToLower();

            var course = this.Seasons[seasonId].Courses[courseId];
            var trainer = this.Trainers.First(x => x.Username.ToLower() == username);

            course.Lectures.Add(this.Factory.CreateLecture(args[2], args[3], trainer));

            return $"Lecture with ID {course.Lectures.Count - 1} was created in course {seasonId}.{course.Name}.";
        }
    }
}
