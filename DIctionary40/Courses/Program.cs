using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> Program = new Dictionary<string, List<string>>();
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string pattern = @"(.+) : (.+)";

                var match = Regex.Match(input, pattern);
                if (Program.ContainsKey(match.Groups[1].Value))
                {
                    Program[match.Groups[1].Value].Add(match.Groups[2].Value);
                }
                else
                {
                    Program.Add(match.Groups[1].Value, new List<string>());
                    Program[match.Groups[1].Value].Add(match.Groups[2].Value);
                }
            }

            foreach (var item in Program.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(item.Key + ": " + item.Value.Count());
                foreach (var set in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + set);
                }
            }



        }
    }
}
