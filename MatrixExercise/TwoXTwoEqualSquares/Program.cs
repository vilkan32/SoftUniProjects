using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoXTwoEqualSquares
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char[,] values = new char[2, 2];
            int occurances = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1] && values[0, 0] != matrix[row, col] && values[0, 1] != matrix[row, col + 1] && values[1, 0] != matrix[row + 1, col] && values[1, 1] != matrix[row + 1, col + 1])
                        {
                            occurances++;
                            values[0, 0] = matrix[row, col];
                            values[0, 1] = matrix[row, col + 1];
                            values[1, 0] = matrix[row + 1, col];
                            values[1, 1] = matrix[row + 1, col + 1];

                            for (int row1 = row; row1 < matrix.GetLength(0) - 1; row1++)
                            {
                                for (int col1 = col; col1 < matrix.GetLength(1) - 1; col1++)
                                {

                                    if (matrix[row1, col1] == values[0, 0] && matrix[row1, col1 + 1] == values[0,1] && values[1,0] == matrix[row1 + 1,col1] && values[1, 1] == matrix[row1 + 1, col1 + 1])
                                    {
                                        occurances++;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            if (occurances <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(occurances - 1);
            }
        }
    }
}
