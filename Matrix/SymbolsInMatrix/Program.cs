using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolsInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string symb = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symb[col];
                }
            }

            char Symbol = char.Parse(Console.ReadLine());
            bool found = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == Symbol)
                    {
                        Console.WriteLine("({0}, {1})", row,col);
                        
                        found = true;
                        break;
                    }
               
                }


                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("{0} does not occur in the matrix", Symbol);
            }

        }
    }
}
