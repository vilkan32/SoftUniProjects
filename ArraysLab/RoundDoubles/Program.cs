using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundDoubles
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " => " + "{0}", Math.Round(input[i], 0, MidpointRounding.AwayFromZero));
            }


        }
    }
}
