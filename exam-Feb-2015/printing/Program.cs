using System;

namespace printing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (n*s)/(double)500*p);
        }
    }
}
