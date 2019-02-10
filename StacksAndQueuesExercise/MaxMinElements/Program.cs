using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> Nums = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    Nums.Push(commands[1]);
                }
                else if (commands[0] == 2 && Nums.Any())
                {
                    Nums.Pop();
                }
                else if (commands[0] == 3 && Nums.Any())
                {
                    Console.WriteLine(Nums.Max());
                }
                else if (commands[0] == 4 && Nums.Any())
                {
                    Console.WriteLine(Nums.Min());
                }
            }

            Console.WriteLine(string.Join(", ", Nums));
        }
    }
}
