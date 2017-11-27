using System;

namespace SimpleCalculations
{
    public class AfterDays
    {
        static void Main()
        {
            var format = "dd-MM-yyyy";
            var birthDay = DateTime.ParseExact(Console.ReadLine(), format, null);
            Console.WriteLine(birthDay.AddDays(999).ToString(format));
        }
    }
}
