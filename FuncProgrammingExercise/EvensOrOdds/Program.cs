using System;
using System.Collections.Generic;
using System.Linq;

namespace EvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            string condition = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                Predicate<int> retu = EvenOrOdd(condition);
                var res = retu(i);
                if (res)
                {
                    Console.Write(i+ " ");
                }
            }

        }

        public static Predicate<int> EvenOrOdd (string cond)
        {
            if (cond == "even")
            {
                return x => x % 2 == 0;
            }
            else
            {
                return x => x % 2 != 0;
            }
        }
    }
}
