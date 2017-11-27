using System;
using System.Linq;
using System.Text;

namespace StringPractice
{
    public class Series
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = new StringBuilder();
            var current = text[0];

            for (var i = 0; i < text.Length; i++)
            {
                if (current != text[i])
                {
                    result.Append(current);
                    current = text[i];
                }
            }

            result.Append(text.Last());

            Console.WriteLine(result.ToString());
        }
    }
}
