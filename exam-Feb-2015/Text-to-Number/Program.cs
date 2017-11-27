using System;

namespace Text_to_Number
{
    class Program
    {
        static void Main()
        {
            short m = short.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToUpper();
            char currentChar;
            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                currentChar = text[i];

                if (currentChar == '@')
                {
                    Console.WriteLine(result);
                    break;
                }
                else if (currentChar >= 48 && currentChar <= 57)
                {
                    result *= byte.Parse(currentChar.ToString());
                }
                else if (currentChar >=65 && currentChar <=90)
                {
                    result += currentChar - 65;
                }
                else
                {
                    result = result % m;
                }
            }
        }
    }
}
