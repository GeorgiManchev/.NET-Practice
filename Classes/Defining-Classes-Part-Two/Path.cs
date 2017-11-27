using System;
using System.Collections.Generic;

namespace Defining_Classes_Part_Two
{
    public class Path
    {
        public IEnumerable <Point3D> Points { get; set; }

        public Path(IEnumerable<Point3D> points)
        {
            this.Points = points;
        }
    }
}
