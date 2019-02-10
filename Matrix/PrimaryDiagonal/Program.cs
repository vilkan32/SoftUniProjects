using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            int[,] matrix = new int[a, a];
            int sum = 0;
            for (int row = 0; row < a; row++)
            {
                int[] Row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < a; col++)
                {
                    matrix[row, col] = Row[col];
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
