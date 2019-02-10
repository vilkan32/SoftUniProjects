using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long multiplier = long.Parse(Console.ReadLine());
            for (int i = (int)multiplier; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
            }
            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", number, multiplier
                    , number * multiplier);
            }
        }
    }
}
