using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var mathces = Regex.Matches(input, @"([A-Za-z]+)(.+)(\1)").Cast<Match>().ToArray();
            var mathcese = Regex.Matches(input, @"([A-Za-z]+)(.+)(\1)").Cast<Match>().Select(x => x.Value).ToArray();
            var matchNext = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            List<string> resultat = new List<string>();
            if (true)
            {
                for (int i = 0; i < Math.Min(mathcese.Length, matchNext.Length); i++)
                {
                    if (i >= matchNext.Count())
                    {
                        break;
                    }
                    Regex rgx = new Regex(Regex.Escape(mathces[i].Groups[2].Value));
                    var output = rgx.Replace(mathces[i].Value, matchNext[i], 1);
                    resultat.Add(output);

                }

                for (int i = 0; i < resultat.Count(); i++)
                {
                    Regex rgx = new Regex(Regex.Escape(mathcese[i]));
                    var output = rgx.Replace(input, resultat[i], 1);
                    input = output;
                }
            }
            Console.WriteLine(input);
        }
    }
}
