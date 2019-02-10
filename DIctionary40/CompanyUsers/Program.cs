using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> CompanyPersonnel = new Dictionary<string, List<string>>();
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string pattern = @"(.+) -> (.+)";

                var match = Regex.Match(input, pattern);

                if (CompanyPersonnel.ContainsKey(match.Groups[1].Value))
                {
                    if (!CompanyPersonnel[match.Groups[1].Value].Contains(match.Groups[2].Value))
                    {
                        CompanyPersonnel[match.Groups[1].Value].Add(match.Groups[2].Value);

                    }
                }
                else
                {
                  
                        CompanyPersonnel.Add(match.Groups[1].Value, new List<string>());
                        CompanyPersonnel[match.Groups[1].Value].Add(match.Groups[2].Value);

                }
            }

            foreach (var item in CompanyPersonnel.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var set in item.Value)
                {
                    Console.WriteLine("-- " + set);
                }
            }
        }
    }
}
