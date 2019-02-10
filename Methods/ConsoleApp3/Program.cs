using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            PrintBody(n);
            PrintHeader(n);


        }

        static void PrintHeader(int n)
        {

            Console.WriteLine(new string ('-', n * 2));
        }

        static void PrintBody(int n)
        {

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('-');
                for (int y = 1; y <= (2 * n -2) / 2; y++)
                {
                    
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }

        }
    }
}
