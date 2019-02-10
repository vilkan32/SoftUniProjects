using System;
using System.Collections.Generic;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<String> Input = Console.ReadLine().Split(' ').Where(x => char.IsUpper(x[0])).ToList();

            Input.ForEach(Print)



        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
