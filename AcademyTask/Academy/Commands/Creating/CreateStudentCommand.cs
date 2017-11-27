using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Creating
{
    public class CreateStudentCommand : CreateCommand
    {
        public CreateStudentCommand(IAcademyFactory factory, IDataManager manager) : base(factory, manager) { }

        public override string Execute(IList<string> args)
        {
            var name = args[0].ToLower();
            var track = args[1];
            var student = this.Factory.CreateStudent(name, track);

            if (this.Students.Select(x => x.Username.ToLower()).Any(x => x == name) ||
                this.Trainers.Select(x => x.Username.ToLower()).Any(x => x == name))
            {
                throw new ArgumentException($"A user with the username {args[0]} already exists!");
            }

            this.Students.Add(student);

            return $"Student with ID {this.Students.Count - 1} was created.";
        }
    }
}
