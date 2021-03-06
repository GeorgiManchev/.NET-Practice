﻿using Academy.Models.Abstractions;
using System.Text;

namespace Academy.Models.LectureResources
{
    public class PresentationResource : Resource
    {
        public PresentationResource(string name, string url) : base(name, url) { }

        protected override void Info(StringBuilder builder)
        {
            builder.AppendLine($"     - Type: Presentation");
        }
    }
}
