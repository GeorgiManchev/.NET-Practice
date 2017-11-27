using System;

namespace SimpleCalculations
{
    public class InchesToCentimeters
    {
        static void Main()
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());

            Console.Write("centimeters = ");
            Console.WriteLine(inches * 2.54);
        }
    }
}