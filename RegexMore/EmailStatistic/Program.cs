using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmailStatistic
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^([a-zA-Z]{5,})@([a-z]{3,}(\.com|\.bg|\.org))$";

            int a = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> DomainUsername = new Dictionary<string, List<string>>();
            for (int i = 0; i < a; i++)
            {

                string input = Console.ReadLine();

                var match = Regex.Match(input, pattern);
                if (match.Success == true)
                {
                    if (!DomainUsername.ContainsKey(match.Groups[2].Value))
                    {
                        DomainUsername.Add(match.Groups[2].Value, new List<string>());
                        DomainUsername[match.Groups[2].Value].Add(match.Groups[1].Value);
                    }
                    else
                    {
                        if (DomainUsername.ContainsKey(match.Groups[2].Value) && DomainUsername[match.Groups[2].Value].Contains(match.Groups[1].Value))
                        {
                            continue;
                        }
                        else
                        {
                            DomainUsername[match.Groups[2].Value].Add(match.Groups[1].Value);
                        }
                    }
                }
            }

            foreach (var item in DomainUsername.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine(item.Key + ":");
                foreach (var items in item.Value)
                {
                    Console.WriteLine("### " + items);
                }
            }



        }
    }
}
