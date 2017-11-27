using System;

namespace SimpleCalculations
{
    public class Greeting
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
