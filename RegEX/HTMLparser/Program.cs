using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HTMLparser
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var title = Regex.Match(input, @"<title>(.+)<\/title>");
            string[] resulto = Regex.Split(title.Groups[1].Value, @"\\[nstr0]").ToArray();
            Console.Write("Title: ");
            foreach (var set in resulto.Where(x => x != ""))
            {
                Console.Write(set + " ");
            }
            Console.WriteLine();

            var reworked = Regex.Match(input, @"<body>.+<\/body>").Value;

            var Text = Regex.Matches(reworked, @">([^<]+)<").Cast<Match>().Select(x => x.Groups[1].Value).ToArray();
            Console.Write("Content: ");
            foreach (var item in Text)
            {

                string[] result = Regex.Split(item, @"\\[nstr0]").ToArray();
                foreach (var set in result.Where(x => x != ""))
                {
                    Console.Write(set + " ");
                }
            }


            Console.WriteLine();
        }
    }
}
