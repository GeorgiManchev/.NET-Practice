using System;

namespace Arrays
{
    public class MaximumSum
    {
        public static void Main()
        {
            var holder = Console.ReadLine().Split(' ');
            var rows = int.Parse(holder[0]);
            var cols = int.Parse(holder[1]);

            var numbers = new int[rows, cols];

            for (var row = 0; row < rows; row++)
            {
                var colHolder = Console.ReadLine().Split(' ');
                for (var col = 0; col < cols; col++)
                {
                    numbers[row, col] = int.Parse(colHolder[col]);
                }
            }

            var cell = 3;
            var largestSum = -9000;

            for (var row = 0; row <= rows - cell; row++)
            {
                for (var col = 0; col <= cols - cell; col++)
                {
                    var sum = 0;
                    //THIS IS THE CELL
                    sum += numbers[row, col];
                    sum += numbers[row, col + 1];
                    sum += numbers[row, col + 2];

                    sum += numbers[row + 1, col];
                    sum += numbers[row + 1, col + 1];
                    sum += numbers[row + 1, col + 2];

                    sum += numbers[row + 2, col];
                    sum += numbers[row + 2, col + 1];
                    sum += numbers[row + 2, col + 2];

                    if (sum > largestSum)
                    {
                        largestSum = sum;
                    }
                }
            }
            Console.WriteLine(largestSum);
        }
    }
}
