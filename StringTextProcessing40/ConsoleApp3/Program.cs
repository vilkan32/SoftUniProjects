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
            string input = Console.ReadLine().ToUpper();           
            var rega = Regex.Matches(input, @"([^\d]{1,20})([\d]+)");
            StringBuilder  result = new StringBuilder();
            foreach (Match item in rega)
            {
                if (int.Parse(item.Groups[2].Value) > 20 || int.Parse(item.Groups[2].Value) < 1)
                {
                    continue;
                }
                for (int x = 0; x < int.Parse(item.Groups[2].Value); x++)
                {
                    result.Append(item.Groups[1].Value);
                }
            }     
            char[] distincted = result.ToString().ToCharArray().Distinct().ToArray();
            Console.WriteLine("Unique symbols used: {0}", distincted.Length);
            Console.WriteLine(result);

        }
    }
}
