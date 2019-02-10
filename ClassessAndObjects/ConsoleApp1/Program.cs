using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger input = BigInteger.Parse(Console.ReadLine());

            BigInteger factorail = input;
            for (int i = 1; i < input; i++)
            {
                factorail = factorail * i;
            }
            Console.WriteLine(factorail);





        }
    }
}
