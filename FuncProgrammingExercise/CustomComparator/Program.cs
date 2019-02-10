using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            var even = input.Where(x => x % 2 == 0).ToList();

            var odd = input.Where(x => x % 2 != 0).ToList();
            
            even.Sort(Compare);
            odd.Sort();

            even.AddRange(odd);

            foreach (var item in even)
            {
                Console.Write(item + " ");
            }



        }

        public static int Compare(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                return a.CompareTo(b);
            }
            else
            {
                return null;
            }


        }
    }
}
