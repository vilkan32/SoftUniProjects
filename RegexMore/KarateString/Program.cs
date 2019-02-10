using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace KarateString
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int punchstr = 0;
            string pattern = @">(\d+)(\w+)?";
            int punchstrRemaining = 0;
            var match = Regex.Matches(input, pattern);
            Regex Output = new Regex(input);
            foreach (Match item in match)
            {
                int punchstrfromcurrentitem = Convert.ToInt32(item.Groups[1].Value.ToString());
                punchstrfromcurrentitem += punchstrRemaining;
                string shouldberepaced = item.Value;
                string with = shouldberepaced[0].ToString();
                for (int i = 1; i < shouldberepaced.Length; i++)
                {
                    punchstrfromcurrentitem--;
                    if (punchstrfromcurrentitem < 0)
                    {
                        with += shouldberepaced[i];
                    }
                }
                if (punchstrfromcurrentitem < 0)
                {
                    punchstrRemaining = 0;
                    punchstrfromcurrentitem = 0;
                }
                else
                {
                    punchstrRemaining = punchstrfromcurrentitem;
                }
                var regex = new Regex(Regex.Escape($@"{shouldberepaced}"));
                var Regexasd = regex.Replace(input, with, 1);
                input = Regexasd.ToString();
            }

            Console.WriteLine(input);
        }
    }
}
