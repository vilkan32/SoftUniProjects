using System;
using System.Collections.Generic;
using System.Linq;
namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', '\t', StringSplitOptions.RemoveEmptyEntries).ToList();

            input.ForEach(x => Console.WriteLine("Sir {0}", x));
        }


        public static void Print(string x)
        {
            Console.WriteLine("Sir {0}", x);
        }
    }

   
}
