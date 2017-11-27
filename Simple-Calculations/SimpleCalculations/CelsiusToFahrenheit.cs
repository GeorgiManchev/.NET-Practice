using System;

namespace SimpleCalculations
{
    public class CelsiusToFahrenheit
    {
        static void Main()
        {
            var c = double.Parse(Console.ReadLine());
            var f = c * 9 / 5 + 32;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}