using System;

namespace SimpleCalculations
{
    public class RadToDeg
    {
        static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(rad * 180 / Math.PI, 2));
        }
    }
}
