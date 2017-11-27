using System;

namespace Number_Of_Pages
{
    class Program
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 1;
            for (int i = pages; i < digits;)
            {
                pages++;
                if (pages < 10)
                {
                    digits = digits - 1;
                }
                else if (pages < 100)
                {
                    digits = digits - 2;
                }
                else if (pages < 1000)
                {
                    digits = digits - 3;
                }
                else if (pages < 10000)
                {
                    digits = digits - 4;
                }
                else if (pages < 100000)
                {
                    digits = digits - 5;
                }
                else if (pages < 1000000)
                {
                    digits = digits - 6;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
