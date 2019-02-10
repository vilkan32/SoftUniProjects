using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keypattern = @"(\w+)([<\|\\]\w+[<\|\\])(\w+)";
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            var match = Regex.Match(text, keypattern);

            string start = match.Groups[1].ToString();
            string end = match.Groups[3].ToString();

            string pattern = $@"({start})(.*?)({end})";

            var matchinput = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Groups[2]).Where(a => a.Value != "").ToArray();
           
           
           

            if (matchinput.Length > 0)
            {
                foreach (var item in matchinput)
                {
                    Console.Write(item.Value);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }

        }
    }
}
