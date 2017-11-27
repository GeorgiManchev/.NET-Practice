using System;

namespace BitsToBits
{
    class Program
    {
        static void Main()
        {
            //input
            byte n = byte.Parse(Console.ReadLine());
            string sequance = "";
            for (int i = 0; i < n; i++)
            {
                sequance += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
            }
            string zero = "0";
            string one = "1";

            for (int i = 0; i < sequance.Length; i++)
            {
                if (sequance.Contains(zero))
                {
                    zero += '0';
                }
                if (sequance.Contains(one))
                {
                    one += '1';
                }

            }

            Console.WriteLine(zero.Length - 1);
            Console.WriteLine(one.Length - 1);
        }
    }
}
