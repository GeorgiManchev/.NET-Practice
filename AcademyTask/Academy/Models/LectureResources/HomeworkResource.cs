using Academy.Models.Abstractions;
using System;
using System.Text;

namespace Academy.Models.LectureResources
{
    public class HomeworkResource : Resource
    {
        private readonly DateTime dueDate;
        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.dueDate = dueDate;
        }

        public DateTime DueDate { get => this.dueDate; }

        protected override void Info(StringBuilder builder)
        {
            builder.AppendLine($"     - Type: Homework");
            builder.AppendLine($"     - Due date: {this.dueDate}");
        }
    }
}