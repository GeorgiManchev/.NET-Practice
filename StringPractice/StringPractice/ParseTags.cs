using System;
using System.Text;

namespace StringPractice
{
    public class ParseTags
    {
        private const string O = "<upcase>";
        private const string E = "</upcase>";

        public static void Main()
        {
            Console.WriteLine(ToUpper(Console.ReadLine()));
        }

        private static string ToUpper(string text)
        {
            var result = new StringBuilder(text);
            var nextIndex = 0;
            var posOpen = 0;
            var posEnd = 0;

            while (posOpen > -1)
            {
                posOpen = text.IndexOf(O);
                posEnd = text.IndexOf(E, posOpen + O.Length);

                var lowCase = text.Substring(posOpen, (posEnd - posOpen) + E.Length);
                nextIndex = lowCase.Length;
                var upCase = text.Substring(posOpen + O.Length, nextIndex - O.Length - E.Length).ToUpper();
                result.Replace(lowCase, upCase);

                posOpen = text.IndexOf(O, posOpen + nextIndex);
            }
            return result.ToString();
        }
    }
}
