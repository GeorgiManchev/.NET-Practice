using System;
using System.Linq;
using System.Text;

namespace StringPractice
{
    public class ReplaceTags
    {
        public static void Main()
        {
            var result = new StringBuilder(Console.ReadLine().
                Replace("<a href=\"", "(").
                Replace("\">", ")[").
                Replace("</a>", "]"));
            Console.WriteLine(Replace(result));
        }

        static string Replace(StringBuilder input)
        {
            var map = input.ToString();
            var start = map.IndexOf('[');
            var end = map.IndexOf(']', start);
            var holder = string.Empty;

            for (var i = map.IndexOf('('); i > -1;)
            {
                holder = map.Substring(start, end - start + 1);

                input.Replace(holder, "");
                input.Insert(i, holder);

                i = map.IndexOf('(', end);

                start = map.IndexOf('[', i);
                end = map.IndexOf(']', start);
            }
            return input.ToString();
        }
    }
}
