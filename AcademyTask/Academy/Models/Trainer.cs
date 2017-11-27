using Academy.Models.Abstractions;
using System.Collections.Generic;
using System.Text;

namespace Academy.Models
{
    public class Trainer : User
    {
        private readonly ICollection<string> technologies;

        public Trainer(string username, ICollection<string> technologies) : base(username)
        {
            this.technologies = technologies;
        }

        public ICollection<string> Technologies { get => this.technologies; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("* Trainer:");
            result.AppendLine($" - Username: {base.Username}");
            result.AppendLine($" - Technologies: {string.Join("; ", this.technologies)}");

            return result.ToString();
        }
    }
}
