namespace Defining_Classes_Part_Two
{
    public static class Calculations3D
    {
        public static Point3D GetDistance(Point3D start, Point3D end)
        {
            return new Point3D(end.X - start.X, end.Y - start.Y, end.Z - start.Z);
        }

    }
}
