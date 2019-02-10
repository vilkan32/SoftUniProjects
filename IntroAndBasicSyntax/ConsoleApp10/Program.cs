using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
