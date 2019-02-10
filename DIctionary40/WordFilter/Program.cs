using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(' ').Where(x => x.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join("\r\n", Input));
        }
    }
}
