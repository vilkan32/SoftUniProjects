using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTheTriangeFirstPart(n);

            PrindTheTriangleSecondPart(n);
        }

        static void PrintTheTriangeFirstPart(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <=i ; x++)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

        }

        static void PrindTheTriangleSecondPart(int n)
        {

            for (int i = n - 1; i >= 1; i--)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
