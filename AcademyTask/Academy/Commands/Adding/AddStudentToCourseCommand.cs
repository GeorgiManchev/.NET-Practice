using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Adding
{
    public class AddStudentToCourseCommand : Command
    {
        public AddStudentToCourseCommand(IDataManager manager) : base(manager) { }

        public override string Execute(IList<string> args)
        {
            var username = args[0].ToLower();
            var seasonId = int.Parse(args[1]);
            var courseId = int.Parse(args[2]);
            var form = args[3].ToLower();

            var student = this.Students.First(x => x.Username.ToLower() == username);
            var course = this.Seasons[seasonId].Courses[courseId];

            switch (form)
            {
                case "onsite":
                    course.OnsiteStudents.Add(student);
                    break;
                case "online":
                    course.OnlineStudents.Add(student);
                    break;
                default:
                    throw new ArgumentException($"Cannot add student to course {seasonId}.{course.Name}. Invalid course form {form}!");
            }

            return $"Student {args[0]} was added to Course {seasonId}.{course.Name}.";
        }
    }
}
