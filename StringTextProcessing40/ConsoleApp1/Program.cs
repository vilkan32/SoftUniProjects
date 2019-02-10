using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder input = new StringBuilder(Console.ReadLine().ToUpper());
           
            StringBuilder sb = new StringBuilder();
            
            var nonnumber = Regex.Replace((input.ToString()), "[0-9]", string.Empty);
            var asd = nonnumber.Distinct();
            var distinct = asd.Aggregate(string.Empty, (current, c) => current + c.ToString());

            
            Console.WriteLine("Unique symbols used: {0}", distinct.Count());

            var digits = Regex.Matches(input.ToString(), @"[0-9]+").Cast<Match>().Select(x => x.Value).ToArray();

            var regex = Regex.Replace(input.ToString(), @"[0-9]+", "putkaskartofi");
            var splitter = regex.Split("putkaskartofi", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string result =  string.Empty;
            for (int i = 0; i < splitter.Length; i++)
            {

                for (int x = 0; x < int.Parse(digits[i]); x++)
                {
                    result += splitter[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
