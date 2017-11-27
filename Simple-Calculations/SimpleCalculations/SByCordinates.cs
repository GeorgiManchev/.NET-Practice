using System;

namespace SimpleCalculations
{
    public class SByCordinates
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            Console.WriteLine(a * b);
            Console.WriteLine(2 * (a + b));
        }
    }
}
