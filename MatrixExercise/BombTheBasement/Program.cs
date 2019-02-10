using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[][] jagged = new int[dimensions[0]][];

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new int[dimensions[1]];
               
            }

            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (Math.Pow((double)row - (double)command[0], 2d) + Math.Pow((double)col - (double)command[1], 2d) <= Math.Pow((double)command[2], 2d))
                    {
                        jagged[row][col] = 1;
                    }
                }
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join("", item));
            }

            List<int> list = new List<int>();
            for (int col = 0; col < dimensions[1]; col++)
            {
                for (int row = 0; row < dimensions[0]; row++)
                {
                    list.Add(jagged[row][col]);
                }

                if (!list.Contains(1))
                {
                   
                }
                else
                {
                    list.Sort();
                    list.Reverse();
                    for (int i = 0; i < dimensions[0]; i++)
                    {
                        jagged[i][col] = list[i];
                    }
                }

                list = new List<int>();

            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join("", item));
            }



        }
    }
}
