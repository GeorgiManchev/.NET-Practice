using System;

namespace Jump
{
    class Program
    {
        static void Main()
        {
            char[] map = Console.ReadLine().ToCharArray();
            sbyte i = 0;
            while (i >= 0 && i < map.Length)
            {
                if (map[i] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    break;
                }
                else if (map[i] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }
                else
                {
                    i = ((map[i] - '0') % 2 == 0) ? i += (sbyte)(map[i] - '0') : i -= (sbyte)(map[i] - '0');
                }
            }

            if (i < 0 || i > map.Length)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", i);
            }
        }
    }
}
