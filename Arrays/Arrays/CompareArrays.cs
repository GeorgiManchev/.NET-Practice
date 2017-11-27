using System;

namespace Arrays
{
    public class CompareArrays
    {
        public static void Main()
        {
            var arrayOne = new int[int.Parse(Console.ReadLine())];
            for (var i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != int.Parse(Console.ReadLine()))
                {
                    Console.WriteLine("Not equal");
                    return;
                }
            }
            Console.WriteLine("Equal");
        }
    }
}
