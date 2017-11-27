using System;

namespace Arrays
{
    public class Scanner
    {
        public static void Main()
        {
            var holder = Console.ReadLine().Split(' ');
            var rows = uint.Parse(holder[0]);
            var cols = uint.Parse(holder[1]);

            var numbers = new string[rows, cols];

            for (var row = 0; row < rows; row++)
            {
                var colHolder = Console.ReadLine().Split(' ');
                for (var col = 0; col < cols; col++)
                {
                    numbers[row, col] = colHolder[col];
                }
            }

            var longest = 1;

            for (var r = 0; r < rows; r++)
            {
                for (var c = 0; c < cols; c++)
                {
                    var current = numbers[r, c];
                    var count = 1;
                    // Right direction
                    while ((c + count) < cols && current == numbers[r, c + count])
                    {
                        count++;
                    }
                    //Down direction
                    while ((r + count) < rows && current == numbers[r + count, c])
                    {
                        count++;
                    }
                    //Diagonal direction 0,0 => ++
                    while ((r + count) < rows && (c + count) < cols && current == numbers[r + count, c + count])
                    {
                        count++;
                    }
                    //Diagonal direction first row, last col = > +row - col
                    while ((r + count) < rows && (c - count) > -1 && current == numbers[r + count, c - count])
                    {
                        count++;
                    }
                    longest = (count > longest) ? count : longest;
                }
            }
            Console.WriteLine(longest);
        }
    }
}
