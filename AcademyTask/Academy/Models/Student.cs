using Academy.Models.Abstractions;
using Academy.Models.Enums;
using System.Collections.Generic;
using System.Text;

namespace Academy.Models
{
    public class Student : User
    {
        private readonly Track track;
        private readonly ICollection<CourseResult> courseResults;

        public Student(string username, Track track) : base(username)
        {
            this.track = track;
            this.courseResults = new List<CourseResult>();
        }

        public Track Track { get => this.track; }

        public ICollection<CourseResult> CourseResults { get => this.courseResults; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"* Student:");
            result.AppendLine($" - Username: {base.Username}");
            result.AppendLine($" - Track: {this.track}");
            result.AppendLine($" - Course results:");

            if (this.courseResults.Count > 0)
            {
                result.AppendLine(string.Join("\n", this.courseResults));
            }
            else
            {
                result.AppendLine("  * User has no course results!");
            }

            return result.ToString();
        }
    }
}
