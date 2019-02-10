using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum3X3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int maxSum = 0;
            int[,] threeXthreeSquare = new int[3, 3];

            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] > maxSum)
                    {
                        maxSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        threeXthreeSquare[0, 0] = matrix[row, col];
                        threeXthreeSquare[0, 1] = matrix[row, col + 1];
                        threeXthreeSquare[0, 2] = matrix[row, col + 2];
                        threeXthreeSquare[1, 0] = matrix[row + 1, col];
                        threeXthreeSquare[1, 1] = matrix[row + 1, col + 1];
                        threeXthreeSquare[1, 2] = matrix[row + 1, col + 2];
                        threeXthreeSquare[2, 0] = matrix[row + 2, col];
                        threeXthreeSquare[2, 1] = matrix[row + 2, col + 1];
                        threeXthreeSquare[2, 2] = matrix[row + 2, col + 2];

                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);
            for (int row = 0; row < threeXthreeSquare.GetLength(0); row++)
            {
                for (int col = 0; col < threeXthreeSquare.GetLength(1); col++)
                {
                    Console.Write(threeXthreeSquare[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
