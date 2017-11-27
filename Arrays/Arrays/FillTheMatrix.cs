using System;

namespace Arrays
{
    public class FillTheMatrix
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new int[n, n];

            switch (Console.ReadLine()[0])
            {
                case 'a':
                    MatrixConsistent(result);
                    break;
                case 'b':
                    MatrixSnake(result);
                    break;
                case 'c':
                    MatrixDiagonal(result);
                    break;
                case 'd':
                    MatrixSpiral(result);
                    break;
            }

            for (var r = 0; r < n; r++)
            {
                for (var c = 0; c < n; c++)
                {
                    if (c != n - 1)
                    {
                        Console.Write(result[r, c] + " ");

                    }
                    else
                    {
                        Console.Write(result[r, c]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void MatrixDiagonal(int[,] numbers)
        {
            //b
        }

        private static void MatrixConsistent(int[,] numbers)
        {
            //a
            var counter = 1;
            for (var col = 0; col < numbers.GetLength(1); col++)
            {
                for (var row = 0; row < numbers.GetLength(0); row++)
                {
                    numbers[row, col] = counter;
                    counter++;
                }
            }
        }

        private static void MatrixSpiral(int[,] numbers)
        {
            //d
        }

        private static void MatrixSnake(int[,] numbers)
        {
            //b
            var counter = 1;
            for (var col = 0; col < numbers.GetLength(1); col += 2)
            {
                for (var r = 0; r < numbers.GetLength(0); r++)
                {
                    numbers[r, col] = counter;
                    counter++;
                }
                for (var r = numbers.GetLength(0) - 1; r > -1; r--)
                {
                    numbers[r, col + 1] = counter;
                    counter++;
                }
            }
        }
    }
}
