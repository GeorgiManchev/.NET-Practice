using System;

namespace Encoding_Sum
{
    class Program
    {
        static void Main()
        {
            ushort m = ushort.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToLower();
            decimal result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == '@')
                {
                    break;
                }
                else if (c >= '0' && c <= '9')
                {
                    result *= c - '0';
                }
                else if (c >= 'a' && c <= 'z')
                {
                    result += c - 'a';
                }
                else
                {
                    result = result % m;
                }
            }
            Console.WriteLine(result);
        }
    }
}
