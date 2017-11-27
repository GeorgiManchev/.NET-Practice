using System;

namespace Mixing_Number
{
    class Program
    {
        static void Main()
        {
            ushort n = ushort.Parse(Console.ReadLine());
            string[] numbers = new string[n];
            for (ushort i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            string mixed = "";
            string substracted = "";
            for (ushort i = 0; i < numbers.Length - 1; i++)
            {
                mixed += (numbers[i][1] - '0') * (numbers[i + 1][0] - '0') + " ";
                substracted += Math.Abs(byte.Parse(numbers[i]) - byte.Parse(numbers[i + 1])) + " ";
            }
            Console.WriteLine(mixed);
            Console.WriteLine(substracted);
        }
    }
}
