using System;
using System.Text;

namespace Academy.Models.Abstractions
{
    public abstract class Resource
    {
        private readonly string name;
        private readonly string url;

        public Resource(string name, string url)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 15)
            {
                throw new ArgumentException("Resource name should be between 3 and 15 symbols long!");
            }
            this.name = name;

            if (string.IsNullOrWhiteSpace(url) || url.Length < 5 || url.Length > 150)
            {
                throw new ArgumentException("Resource url should be between 5 and 150 symbols long!");
            }
            this.url = url;
        }

        public string Name { get => this.name; }

        public string Url { get => this.url; }

        abstract protected void Info(StringBuilder builder);

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"    * Resource:");
            result.AppendLine($"     - Name: {this.name}");
            result.AppendLine($"     - Url: {this.url}");

            this.Info(result);

            return result.ToString();
        }
    }
}
