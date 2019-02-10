using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DigitLetterOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();

            var digits = Regex.Matches(inp, @"[0-9]").Cast<Match>().Select(a => a.Value).ToArray();
            var letters = Regex.Matches(inp, @"[A-Za-z]").Cast<Match>().Select(a => a.Value).ToArray();
            var specials = Regex.Matches(inp, @"[^A-Za-z0-9]").Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join("",digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", specials));
        }
    }
}
