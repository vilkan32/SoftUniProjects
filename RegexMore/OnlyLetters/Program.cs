using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\d+[a-zA-Z])";

            var match = Regex.Matches(input, pattern);
            StringBuilder Output = new StringBuilder(input);
            foreach (var item in match)
            {
                var match1 = Regex.Match(item.ToString(), @"[a-zA-Z]");
                Output.Replace(item.ToString(), match1.Value + match1.Value);

            }
            Console.WriteLine(Output.ToString());

        }
    }
}
