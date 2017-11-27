using System;

namespace Devisions
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    for (int d = 1; d < i; d++)
                    {
                        if (d % 2 == 0 && i % d == 0)
                        {
                            sum += d;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
