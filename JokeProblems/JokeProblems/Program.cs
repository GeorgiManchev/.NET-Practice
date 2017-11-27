using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JokeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine());
            //Check for valid input
            HashSet<char> single = new HashSet<char>(input.ToString().Where(x => Char.IsDigit(x) == false));
            if (single.Count > 0)
            {
                Console.WriteLine("Invalid input: {0}", string.Join("", single));
                return;
            }
            else
            {
                single = new HashSet<char>(input.ToString());
            }

            //n^occurences
            var builder = new StringBuilder();
            var key = 0;
            var alpha = "#ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var item in single)
            {
                var power = input.ToString().Count(x => x == item);
                input.Replace(item.ToString(), "", 0, power);
                var calculated = (int)Math.Pow(item - '0', power);
                key += calculated;

                calculated = calculated % 26;
                builder.Append(alpha[calculated]);
            }
            var toEncode = builder.ToString();
            builder.Clear();
            alpha = alpha.Remove(0, 1);
            for (int i = 0; i < toEncode.Length; i++)
            {
                var old = ((toEncode[i] - 'A') + key) % 26;
                builder.Append(alpha[old]);
            }

            Console.WriteLine(builder);
        }
    }
}
