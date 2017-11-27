using System;

namespace StringPractice
{
    public class SubStringOne
    {
        public static void Main()
        {
            var pattern = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();
            var count = 0;

            for (var i = text.IndexOf(pattern); i < text.Length && i > -1; i = text.IndexOf(pattern, i + pattern.Length))
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
