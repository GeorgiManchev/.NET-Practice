using System;

namespace SimpleCalculations
{
    public class CircleArea
    {
        static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Math.PI * r * r);
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * r);
        }
    }
}
