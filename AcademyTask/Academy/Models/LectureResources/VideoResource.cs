using Academy.Models.Abstractions;
using System;
using System.Text;

namespace Academy.Models.LectureResources
{
    public class VideoResource : Resource
    {
        private readonly DateTime uploadedOn;
        public VideoResource(string name, string url, DateTime uploaded) : base(name, url)
        {
            this.uploadedOn = uploaded;
        }

        public DateTime UploadedOn { get => this.uploadedOn; }

        protected override void Info(StringBuilder builder)
        {
            builder.AppendLine($"     - Type: Video");
            builder.AppendLine($"     - Uploaded on: {this.uploadedOn}");
        }
    }
}
