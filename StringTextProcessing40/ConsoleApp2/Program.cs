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

            var regex = Regex.Matches(input, @"[^\d]{1,20}").Cast<Match>().Select(x => x.Value).ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < regex.Length; i++)
            {
                sb.Append(regex[i]);
            }
            char[] distincted = sb.ToString().ToCharArray();
            distincted = distincted.Distinct().ToArray();
            Console.WriteLine("Unique symbols used: {0}", distincted.Length);


          
          

        }
    }
}
