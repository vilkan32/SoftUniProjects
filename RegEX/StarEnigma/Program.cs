using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> AttackedP = new List<string>();
            List<string> DestroyedP = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var decrKey = Regex.Matches(input, @"[starSTAR]").Cast<Match>().Select(x => x.Value).ToArray().Count();

                string Decrypted = string.Empty;
                for (int x = 0; x < input.Length; x++)
                {
                    Decrypted += Convert.ToChar(input[x] - decrKey);
                }

                var regex = Regex.Match(Decrypted, @"@([A-Za-z]+)[^:@!\->]*:(\d+)[^!]*!(A|D)![^:@!\->]*->[^:@!\->\d]*(\d+)");
                if (regex.Success == true)
                {
                    if (regex.Groups[3].Value == "A")
                    {
                        AttackedP.Add(regex.Groups[1].Value);
                    }
                    else if (regex.Groups[3].Value == "D")
                    {
                        DestroyedP.Add(regex.Groups[1].Value);
                    }
                }

            }
            Console.WriteLine("Attacked planets: {0}",AttackedP.Count());
            foreach (var item in AttackedP.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", item);
            }
            Console.WriteLine("Destroyed planets: {0}", DestroyedP.Count());
            foreach (var item in DestroyedP.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", item);
            }
        }
    }
}
