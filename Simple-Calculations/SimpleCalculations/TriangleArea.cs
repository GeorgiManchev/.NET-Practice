using System;

namespace SimpleCalculations
{
    public class TriangleArea
    {
        static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle area = {0}", Math.Round(side * height / 2, 2));
        }
    }
}
