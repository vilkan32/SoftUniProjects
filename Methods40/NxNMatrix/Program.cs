using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int[] row = new int[input];
            for (int i = 0; i < input; i++)
            {
                row[i] = input;
            }

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
