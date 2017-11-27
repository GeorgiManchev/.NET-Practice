using System;
using System.Collections.Generic;

namespace Arrays
{
    struct Cordinat
    {
        private int row;
        private int col;

        public Cordinat(int row = 0, int col = 0)
        {
            this.row = row;
            this.col = col;
        }

        public int GetRow()
        {
            return this.row;
        }

        public int GetCol()
        {
            return this.col;
        }
    }

    public class LargestAreaInMatrix
    {
        public static void Main()
        {
            var holder = Console.ReadLine().Split(' ');
            var rows = int.Parse(holder[0]);
            var cols = int.Parse(holder[1]);

            var numbers = new string[rows, cols];

            for (var row = 0; row < rows; row++)
            {
                var colHolder = Console.ReadLine().Split(' ');
                for (var col = 0; col < cols; col++)
                {
                    numbers[row, col] = colHolder[col];
                }
            }
            // Logic

            var visited = new List<Cordinat>();
            var lastIntersection = new Cordinat();

            var bestCount = 1;

        }

        static int CheckForSameNeighbours(int number)
        {
            return 0;
        }


        static void AddVisitedPovar(List<Cordinat> sheet, Cordinat cordinat)
        {
            if (!sheet.Contains(cordinat) && sheet != null)
            {
                sheet.Add(cordinat);
            }
        }
    }
}
