using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                double a = arr[i];
                Console.WriteLine("{0} => {1}", arr[i], Math.Round(a,0, MidpointRounding.AwayFromZero));
            }

        }
    }
}
