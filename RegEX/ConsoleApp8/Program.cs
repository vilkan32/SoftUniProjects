using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2(\1)(\d{3})(\1)(\d{4})\b";
            string input = Console.ReadLine();


            var matchedphonenubers = Regex.Matches(input, pattern);

            var match = matchedphonenubers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",match));
        }
    }
    
}
