using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int result = 0;
            for (int index = text.Length - 1; index > -1; index--)
            {
                int i = text.Length - index;
                if (Char.IsDigit(text[index]))
                {
                    int digit = int.Parse(text[index].ToString());
                    //even
                    if (i % 2 == 0)
                    {
                        result += digit * digit * (i);
                    }
                    //Odd
                    else
                    {
                        result += digit * (i * i);
                    }
                }
            }
            Console.WriteLine(result);
            char lastDigit = result.ToString()[result.ToString().Length - 1];


            if (lastDigit == '0')
            {
                Console.WriteLine("Big Vik wins again!");
            }
            else
            {
                int messageLength = int.Parse(lastDigit.ToString());
                int messageStart = (result % 26);
                for (int k = 0; k < messageLength; k++)
                {
                    if ((char)('A' + messageStart) == '[')
                    {
                        messageStart = 0;
                    }
                    Console.Write((char)('A' + messageStart));
                    messageStart++;
                }
                Console.WriteLine();
            }
        }
    }
}
