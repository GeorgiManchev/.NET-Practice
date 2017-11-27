using System;

namespace StringPractice
{
    public class ParseUrl
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var data = text.Split(":/".ToCharArray(), 3, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("[protocol] = " + data[0]);
            Console.WriteLine("[server] = " + data[1]);
            Console.WriteLine("[resource] = " + text.Substring(text.IndexOf('/', data[0].Length + 3)));
        }
    }
}