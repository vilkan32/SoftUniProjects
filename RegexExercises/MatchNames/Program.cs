using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            string input = Console.ReadLine();

            var regex = Regex.Matches(input, pattern).Cast<Match>();

            foreach (Match item in regex)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
