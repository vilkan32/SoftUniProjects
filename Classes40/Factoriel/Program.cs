using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

           BigInteger fact = a;
            for (int i = a - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        
    }
}
