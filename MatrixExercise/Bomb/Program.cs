using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int[][] jagged = new int[dimensions][];

            for (int i = 0; i < dimensions; i++)
            {               
                jagged[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string[] coordinates = Console.ReadLine().Split(' ');

            foreach (var item in coordinates)
            {
                int row = int.Parse(item[0].ToString());
                int col = int.Parse(item[2].ToString());
                if (jagged[row][col] <= 0)
                {
                    continue;
                }
                if (col + 1 < dimensions)
                {
                    if (jagged[row][col + 1] > 0)
                    {
                        jagged[row][col + 1] = jagged[row][col + 1] - jagged[row][col];
                    }
                    
                }

                if (col - 1 >= 0)
                {
                    if (jagged[row][col - 1] > 0)
                    {
                        jagged[row][col - 1] = jagged[row][col - 1] - jagged[row][col];
                    }
                    
                }

                if (row - 1 >= 0)
                {
                    if (jagged[row - 1][col] > 0)
                    {
                        jagged[row - 1][col] = jagged[row - 1][col] - jagged[row][col];
                    }
                    
                }

                if (row + 1 < dimensions)
                {
                    if (jagged[row + 1][col] > 0)
                    {
                        jagged[row + 1][col] = jagged[row + 1][col] - jagged[row][col];
                    }
                    
                }

                if (row - 1 >= 0 && col - 1 >= 0)
                {
                    if (jagged[row - 1][col - 1] > 0)
                    {
                        jagged[row - 1][col - 1] = jagged[row - 1][col - 1] - jagged[row][col];
                    }
                    
                }

                if (row - 1 >= 0 && col + 1 < dimensions)
                {
                    if (jagged[row - 1][col + 1] > 0)
                    {
                        jagged[row - 1][col + 1] = jagged[row - 1][col + 1] - jagged[row][col];
                    }
                    
                }

                if (row + 1 < dimensions && col -1 >= 0)
                {
                    if (jagged[row + 1][col - 1] > 0)
                    {
                        jagged[row + 1][col - 1] = jagged[row + 1][col - 1] - jagged[row][col];

                    }
                    
                }

                if (row + 1 < dimensions && col + 1< dimensions)
                {
                    if (jagged[row + 1][col + 1] > 0)
                    {
                        jagged[row + 1][col + 1] = jagged[row + 1][col + 1] - jagged[row][col];
                    }
                    
                }

               
                    jagged[row][col] = 0;
                
            }


            int sum = 0;
            int cells = 0;
            foreach (var item in jagged)
            {
                foreach (var cell in item)
                {
                    if (cell > 0)
                    {
                        sum += cell;
                        cells++;
                    }
                }
            }
         
            Console.WriteLine("Alive cells: {0}", cells);
            Console.WriteLine("Sum: {0}", sum);
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

          
        }
    }
}
