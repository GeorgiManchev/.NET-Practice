using System;

namespace Busses
{
    class Program
    {
        static void Main()
        {
            ushort c = ushort.Parse(Console.ReadLine());
            ushort groups = 0;
            ushort groupSpeed = 1500;
            for (int i = 0; i < c; i++)
            {
                ushort busSpeed = ushort.Parse(Console.ReadLine());
                
                if (busSpeed <= groupSpeed)
                {
                    groupSpeed = busSpeed;
                    groups++;
                }
                
            }
            Console.WriteLine(groups);
        }
    }
}
