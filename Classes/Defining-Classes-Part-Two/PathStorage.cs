using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_Two
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Point3D point in path.Points)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string fileName)
        {
            List<Point3D> points = new List<Point3D>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    int[] point = line
                        .Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                    points.Add(new Point3D(point[0], point[1], point[2]));
                }
            }

            return new Path(points);
        }

    }
}
