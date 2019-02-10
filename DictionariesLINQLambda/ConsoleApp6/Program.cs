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


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = Input.Count / 4;

            List<int> left = Input.Take(k).ToList();
            Input.Reverse();
            List<int> right = Input.Take(k).ToList();
            Input.Reverse();
            left.Reverse();
            
            List<int> mixedlandr = left.Concat(right).ToList();
            List<int> row = Input.Skip(k).Take(2*k).ToList();

            var output = mixedlandr.Select((x, index) => x + row[index]);

            Console.WriteLine(string.Join(" ", output));

            



        }
    }
}
