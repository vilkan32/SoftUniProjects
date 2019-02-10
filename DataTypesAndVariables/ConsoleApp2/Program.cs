using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger a = BigInteger.Parse(Console.ReadLine());

            for (BigInteger i = 0; i < a; i++)
            {
                string input = Console.ReadLine();
                String[] Input = input.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                decimal A = decimal.Parse(Input[0]);
                decimal B = decimal.Parse(Input[1]);
                if (A > B)
                {
                    List<char> BiggerNumberSeparated = Input[0].ToList();
                    BiggerNumberSeparated.Remove(',');
                    BiggerNumberSeparated.Remove('.');
                    BiggerNumberSeparated.Remove('-');
                    long Sumofdigits = 0;

                    for (int x = 0; x < BiggerNumberSeparated.Count(); x++)
                    {
                        Sumofdigits += Convert.ToInt32(BiggerNumberSeparated[x].ToString());

                    }
                    Console.WriteLine(Sumofdigits);
                    continue;
                }
                else
                {
                    List<char> BiggerNumberSeparated = Input[1].ToList();
                    BiggerNumberSeparated.Remove(',');
                    BiggerNumberSeparated.Remove('.');

                    BigInteger Sumofdigits = 0;

                    for (int x = 0; x < BiggerNumberSeparated.Count(); x++)
                    {
                        Sumofdigits +=Convert.ToInt32(BiggerNumberSeparated[x].ToString());

                    }
                    Console.WriteLine(Sumofdigits);
                    continue;
                }

            }
        }
    }
}
