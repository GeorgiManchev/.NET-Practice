using System;

namespace Speed
{
    class Program
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            int sGroup = int.Parse(Console.ReadLine());
            int initSpeedSum = sGroup;
            int topGroupSpeed = sGroup;
            for (int i = 1; i < c; i++)
            {
                int sNow = int.Parse(Console.ReadLine());
                if (sNow > sGroup)
                {
                    initSpeedSum += sNow;
                    if (initSpeedSum > topGroupSpeed)
                    {
                        topGroupSpeed = initSpeedSum;
                    }
                }
                else
                {
                    sGroup = sNow;
                    initSpeedSum = sNow;
                }
            }
            Console.WriteLine(topGroupSpeed);

        }
    }
}
