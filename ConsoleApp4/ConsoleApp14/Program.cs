using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());

            int multiplier = int.Parse(Console.ReadLine());

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
            }

            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", number,multiplier, number * multiplier);
            }
        }
    }
}
