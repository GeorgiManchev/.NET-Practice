using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Models
{
    public class Course
    {
        private readonly string name;
        private readonly int lecturesPerWeek;
        private readonly DateTime startingDate;
        private readonly DateTime endingDate;
        private readonly ICollection<Student> onsiteStudents;
        private readonly ICollection<Student> onlineStudents;
        private readonly ICollection<Lecture> lectures;

        public Course(string name, int lecturesPerWeek, DateTime starting, DateTime ending)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 45)
            {
                throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
            }
            this.name = name;

            if (lecturesPerWeek < 1 || lecturesPerWeek > 7)
            {
                throw new ArgumentException("The number of lectures per week must be between 1 and 7!");
            }
            this.lecturesPerWeek = lecturesPerWeek;

            if (starting == null)
            {
                throw new ArgumentException("The course starting date must be valid!");
            }
            this.startingDate = starting;

            if (ending == null)
            {
                throw new ArgumentException("The course ending date must be valid!");
            }
            this.endingDate = ending;

            this.onsiteStudents = new List<Student>();
            this.onlineStudents = new List<Student>();
            this.lectures = new List<Lecture>();
        }

        public string Name { get => this.name; }

        public int LecturesPerWeek { get => this.lecturesPerWeek; }

        public DateTime StartingDate { get => this.startingDate; }

        public DateTime EndingDate { get => this.endingDate; }

        public ICollection<Student> OnsiteStudents { get => this.onsiteStudents; }

        public ICollection<Student> OnlineStudents { get => this.onlineStudents; }

        public ICollection<Lecture> Lectures { get => this.lectures; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"* Course:");
            result.AppendLine($" - Name: {this.name}");
            result.AppendLine($" - Lectures per week: {this.lecturesPerWeek}");
            result.AppendLine($" - Starting date: {this.startingDate}");
            result.AppendLine($" - Ending date: {this.endingDate}");
            result.AppendLine($" - Onsite students: {this.onsiteStudents.Count}");
            result.AppendLine($" - Online students: {this.onlineStudents.Count}");
            result.AppendLine($" - Lectures:");

            if (this.lectures.Count > 0)
            {
                result.AppendLine(string.Join("\n", this.lectures));
            }
            else
            {
                result.AppendLine("  * There are no lectures in this course!");
            }

            return result.ToString();
        }
    }
}