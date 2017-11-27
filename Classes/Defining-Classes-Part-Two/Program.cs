using System;
namespace Defining_Classes_Part_Two
{
    class Program
    {
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);

        public static Point3D StartPoint => startPoint;

        static void Main(string[] args)
        {
            Console.WriteLine(StartPoint);
        }
    }
}
