using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }


            int maxSum = 0;
            int[,] values = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] > maxSum)
                    {
                        maxSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        values[0, 0] = matrix[row, col];
                        values[0, 1] = matrix[row, col + 1];
                        values[1, 0] = matrix[row + 1, col];
                        values[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(values[0, 0] + " " + values[0, 1]);
            Console.WriteLine(values[1, 0] + " " + values[1, 1]);
            Console.WriteLine(maxSum);

        }
    }
}
