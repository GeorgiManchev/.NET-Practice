using System;

namespace Money
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double realms = (double)(n * s) / 400d;
            double money = p * realms;
            Console.WriteLine("{0:F3}", money);
        }
    }
}
