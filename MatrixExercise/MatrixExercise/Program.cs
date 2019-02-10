using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, n];
            long sumPrimary = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] input = Console.ReadLine().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                }
            }

          
            long row1 = 0;
            
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    sumPrimary -= matrix[row1, col];
                    row1++;
                    
                }
            

            Console.WriteLine(Math.Abs(sumPrimary));
        }
    }
}
