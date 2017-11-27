using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Creating
{
    public class CreateCourseResultCommand : CreateCommand
    {
        public CreateCourseResultCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var seasonId = int.Parse(args[0]);
            var courseId = int.Parse(args[1]);
            var username = args[4].ToLower();

            var course = this.Seasons[seasonId].Courses[courseId];
            var student = this.Students.First(x => x.Username.ToLower() == username);

            if (!course.OnsiteStudents.Contains(student) && !course.OnlineStudents.Contains(student))
            {
                throw new ArgumentException($"The student {args[4]} is not signed up for the course {seasonId}.{course.Name}!");
            }

            student.CourseResults.Add(this.Factory.CreateCourseResult(course, args[2], args[3]));

            return $"Course result with ID {student.CourseResults.Count - 1} was created for Student {args[4]}.";
        }
    }
}
