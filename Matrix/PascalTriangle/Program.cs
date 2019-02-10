using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
            
            
            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;
                jagged[row][jagged[row].Length - 1] = 1;

                if (jagged[row].Length > 2)
                {
                    long[] sum = new long[jagged[row].Length - 2];
                    for (int i = 0; i < jagged[row - 1].Length - 1; i++)
                    {
                        sum[i] = jagged[row - 1][i] + jagged[row - 1][i + 1];
                    }

                    for (int col = 1; col < jagged[row].Length - 1; col++)
                    {
                        jagged[row][col] = sum[col - 1];
                    }
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
