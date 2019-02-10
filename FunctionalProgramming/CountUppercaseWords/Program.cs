using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(' ').Where(x => char.IsUpper(x[0])).ToList().ForEach(Console.WriteLine);
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
