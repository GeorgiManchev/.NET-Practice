using System;

namespace Birds
{
    class Program
    {
        static void Main()
        {
            int birdCount = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());

            if (birdCount % 2 == 0)
            {
                Console.WriteLine("{0:F4}", (feathers / (double)birdCount) * 123123123123);
            }
            else
            {
                Console.WriteLine("{0:F4}", (feathers / (double)birdCount) / 317);
            }
        }
    }
}
