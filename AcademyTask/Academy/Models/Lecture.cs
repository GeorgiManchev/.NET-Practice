using Academy.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Models
{
    public class Lecture
    {
        private readonly string name;
        private readonly DateTime date;
        private readonly Trainer trainer;
        private readonly ICollection<Resource> resources;

        public Lecture(string name, DateTime date, Trainer trainer)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 5 || name.Length > 30)
            {
                throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
            }
            this.name = name;
            this.date = date;
            this.trainer = trainer;
            this.resources = new List<Resource>();
        }

        public string Name { get => this.name; }

        public DateTime Date { get => this.date; }

        public Trainer Trainer { get => this.trainer; }

        public ICollection<Resource> Resources { get => this.resources; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"  * Lecture:");
            result.AppendLine($"   - Name: {this.name}");
            result.AppendLine($"   - Date: {this.date}");
            result.AppendLine($"   - Trainer username: {this.trainer.Username}");
            result.AppendLine($"   - Resources:");

            if (this.resources.Count > 0)
            {
                result.Append(string.Join("\n", this.resources));
            }
            else
            {
                result.Append("    * There are no resources in this lecture.");
            }

            return result.ToString();
        }
    }
}
