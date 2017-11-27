using System;

namespace StringPractice
{
    public class SubStringTwo
    {
        public static void Main()
        {
            var pattern = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();
            if (text.Contains(pattern))
            {
                var count = 0;
                var index = text.IndexOf(pattern);
                while (index < text.Length && index != -1)
                {
                    index = (text.IndexOf(pattern) > -1) ? text.IndexOf(pattern, index + pattern.Length) : text.Length;
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}