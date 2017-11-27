using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            string[] instructions = new string[n];
            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                byte evenSum = 0;
                byte oddSum = 0;
                for (int k = 0; k < digits.Length; k++)
                {
                    if (digits[k] % 2 == 0)
                    {
                        evenSum += (byte)(digits[k] - '0');
                    }
                    else
                    {
                        oddSum += (byte)(digits[k] - '0');
                    }
                }

                if (evenSum > oddSum)
                {
                    instructions[i] = "left";
                }
                else if (oddSum > evenSum)
                {
                    instructions[i] = "right";
                }
                else
                {
                    instructions[i] = "straight";
                }
            }
            for (int i = 0; i < instructions.Length; i++)
            {
                Console.WriteLine(instructions[i]);
            }

        }
    }
}
