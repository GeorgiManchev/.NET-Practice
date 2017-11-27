using System;

namespace Arrays
{
    public class BinarySearch
    {
        static void Main()
        {
            var numbers = new int[20];
            for (var i = 0; i < 20; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine(Binary(numbers, 11, 0, numbers.Length));
        }

        public static int Binary(int[] numbers, int searched, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            var mid = (min + max) / 2;
            if (numbers[mid] == searched)
            {
                return mid;
            }

            if (numbers[mid] < searched)
            {
                mid--;
            }
            else
            {
                mid++;
            }
            return Binary(numbers, searched, min, max);

        }
    }
}
