using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "swap" && command.Count() == 5)
                {
                    try
                    {
                        string substitute = matrix[int.Parse(command[1]), int.Parse(command[2])];
                        matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                        matrix[int.Parse(command[3]), int.Parse(command[4])] = substitute;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col]+ " ");
                            }
                            Console.WriteLine();
                        }

                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid input!");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }
    }
}
