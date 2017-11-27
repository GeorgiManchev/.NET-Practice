using System;
using System.Linq;

namespace Arrays
{
    public enum Direction
    {
        RU, UR, LU, UL, DL, LD, RD, DR
    }

    public class BishopPathFinder
    {
        private static int posRow;
        private static int posCol;
        private static int sum;

        public static void Main()
        {
            var size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var board = new int[size[0], size[1]];

            FillMatrixFromLastRowFirstCol(board, 3);

            var boardMirror = new int[board.GetLength(0), board.GetLength(1)];
            FillMatrixFromLastRowFirstCol(boardMirror, 0);

            posRow = size[0] - 1;

            var directionsCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < directionsCount; i++)
            {
                var rawDirection = Console.ReadLine().Split(" ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);
                Move(board, boardMirror,
                    (Direction)Enum.Parse(typeof(Direction), rawDirection[0]),
                    int.Parse(rawDirection[1]));
            }
            Console.WriteLine(sum);
        }

        private static void Move(int[,] board, int[,] mirror, Direction direction, int step)
        {
            posCol = (posCol < 0) ? 0 : posCol;
            posRow = (posRow < 0) ? 0 : posRow;

            while (step > 0 && posCol < board.GetLength(1) && posRow < board.GetLength(0) &&
            posCol >= 0 && posRow >= 0)
            {
                step--;
                if (mirror[posRow, posCol] == 0)
                {
                    sum += board[posRow, posCol];
                    mirror[posRow, posCol] = 1;
                }
                switch (direction)
                {
                    case Direction.RU:
                    case Direction.UR:
                        posRow--;
                        posCol++;
                        break;
                    case Direction.LU:
                    case Direction.UL:
                        posRow--;
                        posCol--;
                        break;
                    case Direction.DL:
                    case Direction.LD:
                        posRow++;
                        posCol--;
                        break;
                    case Direction.RD:
                    case Direction.DR:
                        posRow++;
                        posCol++;
                        break;
                }
            }
        }

        private static void FillMatrixFromLastRowFirstCol(int[,] array, int step)
        {
            var count = 0;
            for (var row = array.GetLength(0) - 1; row > -1; row--)
            {
                for (var col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = col * step + count;
                }
                count += step;
            }
        }
    }
}