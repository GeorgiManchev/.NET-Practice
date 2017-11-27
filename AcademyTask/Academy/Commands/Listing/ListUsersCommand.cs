using Academy.Commands.Abstractions;
using Academy.Core.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : Command
    {
        public ListUsersCommand(IDataManager dataManager) : base(dataManager) { }

        public override string Execute(IList<string> parameters)
        {
            if (this.Trainers.Count == 0 && this.Students.Count == 0)
            {
                return "There are no registered users!";
            }

            var result = new StringBuilder();
            result.AppendLine(string.Join("\n", this.Trainers));
            result.AppendLine(string.Join("\n", this.Students));

            return result.ToString();
        }
    }
}
