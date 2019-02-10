using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToUpper();
            var nonnumber = Regex.Replace(input, @"[0-9]{1,2}", string.Empty);

            char[] result = nonnumber.Distinct().ToArray();
            Console.WriteLine("Unique symbols used: {0}", result.Length);


            var regex = Regex.Replace(input, @"[0-9]+", "putkaskartofi");
            var splitter = regex.Split(' ').ToArray();
          

        }
    }
}
