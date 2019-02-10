using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(" ", stack.ToArray()));

        }
    }
}
