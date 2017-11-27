using System;

namespace Mythical_Numbers
{
    class Program
    {
        static void Main()
        {
            string digits = Console.ReadLine();
            byte fD = (byte)(digits[0] - '0');
            byte sD = (byte)(digits[1] - '0');
            byte tD = (byte)(digits[2] - '0');
            if (tD == 0)
            {
                Console.WriteLine("{0:f2}", fD * sD);
            }
            else if (0 < tD && tD <= 5)
            {
                Console.WriteLine("{0:f2}", fD * sD / (double)tD);

            }
            else
            {
                Console.WriteLine("{0:f2}", (fD + sD) * tD);
            }
        }
    }
}
