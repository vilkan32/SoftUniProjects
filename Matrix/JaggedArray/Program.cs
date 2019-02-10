using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp = int.Parse(Console.ReadLine());

            int[][] jagged = new int[inp][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    try
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    catch (IndexOutOfRangeException)
                    {

                        Console.WriteLine("Invalid coordinates");
                    }
                }
                if (command[0] == "Subtract")
                {
                    try
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                    catch (IndexOutOfRangeException)
                    {

                        Console.WriteLine("Invalid coordinates");
                    }
                }

            }

            foreach (int[] item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
