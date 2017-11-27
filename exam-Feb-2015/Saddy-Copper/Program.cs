using System;
using System.Numerics;
namespace Saddy_Copper
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); //step 1
            byte transform = 0;
            while (input.Length > 1 && transform < 10)
            {
                BigInteger product = 1;
                while (input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1); //step 2
                    int sum = 0;
                    for (int i = 0; i < input.Length; i += 2) //step 3
                    {
                        sum += (input[i] - '0');
                    }
                    product *= sum != 0 ? sum : 1;
                }
                input = product.ToString();
                transform++;
            }

            if (transform < 10)
            {
                Console.WriteLine(transform);
            }
            Console.WriteLine(input);
   
        }
    }
}

