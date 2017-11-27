using System;
using System.Linq;

namespace StringPractice
{
    public class RecursiveReverse
    {
        public static void Main()
        {
            var text = "misissipi";
            Console.WriteLine(ReverseRecursion(text));

        }

        public static string ReverseRecursion(string text)
        {
            if (text.Length == 1)
            {
                return text;
            }
            var res = text.Last().ToString();
            res += ReverseRecursion(text.Substring(0, text.Length - 1));
            return res;
        }

    }
}
