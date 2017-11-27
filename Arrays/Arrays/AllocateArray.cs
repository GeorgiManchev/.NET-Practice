using System;

namespace Arrays
{
    public class AllocateArray
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            for (var i = 0; i < numbers; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
