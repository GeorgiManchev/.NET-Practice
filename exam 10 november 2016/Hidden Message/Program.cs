using System;

namespace Hidden_Message
{
    class Program
    {
        static void Main()
        {
            string decoded = "";
            while (true)
            {
                string message = Console.ReadLine();
                if (message == "end")
                {
                    Console.WriteLine(decoded);
                    break;
                }
                sbyte start = sbyte.Parse(message);
                sbyte step = sbyte.Parse(Console.ReadLine());
                message = Console.ReadLine();
                start = (start < 0) ? (sbyte)(message.Length + start) : start;
                for (sbyte i = start; (i >= 0 && i < message.Length); i += step)
                {
                    decoded += message[i];
                }
            }
        }
    }
}
