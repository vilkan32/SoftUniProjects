using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintTriangle(int.Parse(Console.ReadLine()));

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n- 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }

        }
    }
}
