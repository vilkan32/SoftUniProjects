using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int read = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnResult1(read));
            
        }

        static BigInteger ReturnResult(int n)
        {
            BigInteger factorial = 1;

            for (int r = 1; r <= n; r++)
            {
                factorial = factorial * r;
            }

            return factorial;
        }

        static int ReturnResult1(int n)

        {
            string checkforzeroes = ReturnResult(n).ToString();
            int returnvalue = 0;
            for (int i = checkforzeroes.Length - 1; i >= 0; i--)
            {

                string saveoutput = "";
                
                
                    saveoutput += checkforzeroes[i];
                    if (saveoutput == "0")
                    {
                        returnvalue += 1;
                    }
                    else
                    {
                        break;
                    }
                    saveoutput = "";
                
            }
            return returnvalue;
        }
    }
}
