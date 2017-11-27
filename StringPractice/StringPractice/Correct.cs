using System;

namespace StringPractice
{
    public class Correct
    {
        public static void Main()
        {
            var data = Console.ReadLine();

            var result = 0;
            for (var i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    result++;
                }
                else if (data[i] == ')')
                {
                    result--;
                }
            }

            if (result != 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}