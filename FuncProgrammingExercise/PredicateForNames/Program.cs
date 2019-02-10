using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Predicate<string> CheckLength = x => x.Length <= n;
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var item in input)
            {
                if (CheckLength(item))
                {
                    Console.WriteLine(item);
                }
            }
            



        }
    }
}
