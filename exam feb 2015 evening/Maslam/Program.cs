using System;

namespace Maslam
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            int transform = 0;
            int product = 1;

            while (number.Length !=1 && transform <= 10)
            {
                int sum = 0;
                number = number.Substring(0, number.Length - 1); //remove last
                for (int i = 1; i < number.Length; i += 2)
                {
                    sum += number[i] - '0'; // sum the numbers
                }

                if (sum != 0)
                {
                    product *= sum;
                }

                if (product.ToString().Length > 1 && number.Length==0)
                {
                    number = product.ToString();
                    product = 1;
                    transform++;
                }
                else if (product.ToString().Length == 1 && number.Length==0)
                {
                    number = product.ToString();
                    transform++;
                    break;
                }
            }
            if (transform < 10)
            {
                Console.WriteLine(transform);
            }
            Console.WriteLine(number);
        }
    }
}
