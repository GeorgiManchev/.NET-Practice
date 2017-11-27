using System;
using System.Numerics;

namespace Mutants
{
    class Program
    {
        static void Main()
        {
            ulong t = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong s = ulong.Parse(Console.ReadLine());
            ulong a = ulong.Parse(Console.ReadLine());

            ulong result = (((t * b) * s) * a);


            if (result % 2 == 0)
            {
                Console.WriteLine("{0:F3}", BigInteger.Multiply(result, 376439));
            }
            else
            {
                Console.WriteLine("{0:F3}", result / 7D);
            }


        }
    }
}
