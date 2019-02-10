using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Input.Sort();

            Console.WriteLine(string.Join(" <= ", Input));






        }
    }
}
