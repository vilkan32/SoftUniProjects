using System;
using System.Collections.Generic;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.2).ToList();
            Action<double> write = (x) => Console.WriteLine($"{x:f2}");
            input.ForEach(write);




        }

     
    }
}
