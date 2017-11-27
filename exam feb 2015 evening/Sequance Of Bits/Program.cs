using System;
using System.Text;

namespace Sequance_Of_Bits
{
    class Program
    {
        static void Main()
        {
            string sb = "";
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sb += (Convert.ToString(uint.Parse(Console.ReadLine()), 2).PadLeft(30, '0'));

            }

            string one = "1", zero = "0";

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb.Contains(one))
                {
                    one += '1';
                }
                if (sb.Contains(zero))
                {
                    zero += '0';
                }
            }

            Console.WriteLine(one.Length-1);
            Console.WriteLine(zero.Length-1);
        }
    }
}
