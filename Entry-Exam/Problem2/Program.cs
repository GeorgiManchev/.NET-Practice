using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            ushort n = ushort.Parse(Console.ReadLine());
            string binNumber = Convert.ToString(n, 2).PadLeft(11, '0');
            string[] sheets = new string[] { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };

            while (binNumber.Contains("1"))
            {
                byte index = (byte)binNumber.IndexOf("1");
                binNumber = binNumber.Remove(index, 1);
                binNumber.Insert(0, "0");
                sheets[index] = "";
            }

            for (int i = 0; i < sheets.Length && sheets[i].Length > 0; i++)
            {
                Console.WriteLine(sheets[i]);
            }
        }
    }
}
