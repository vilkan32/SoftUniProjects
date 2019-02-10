using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int divisible = int.Parse(Console.ReadLine());
            input.Reverse();
            Predicate<int> checkDivisible = x => x % divisible == 0;
            foreach (var item in input)
            {
                var result = checkDivisible(item);
                if (!result)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
