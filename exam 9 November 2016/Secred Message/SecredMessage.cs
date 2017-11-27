using System;

namespace Secred_Message
{
    class Program
    {
        static void Main()
        {
            string decodedMessage = "";
            byte rowCount = 0;
            while (true)
            {
                rowCount++;
                string message = Console.ReadLine();
                if (message == "end")
                {
                    Console.WriteLine(decodedMessage);
                    break;
                }
                sbyte start = sbyte.Parse(message);
                sbyte end = sbyte.Parse(Console.ReadLine());
                message = Console.ReadLine();
                start = (start < 0) ? (sbyte)(message.Length + start) : start;
                end = (end < 0) ? (sbyte)(message.Length + end) : end;
                sbyte step = (rowCount % 2 == 0) ? (sbyte)4 : (sbyte)3;
                for (sbyte i = start; i <= end; i += step)
                {
                    decodedMessage += message[i];
                }
            }
        }
    }
}
