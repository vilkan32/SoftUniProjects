using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace UseChains
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());


            string pattern = @"<p>(.+?)<\/p>";

            MatchCollection matches = Regex.Matches(reader.ReadLine(), pattern);
            StringBuilder sb = new StringBuilder();
            Dictionary<char, char> AtoZConverter = new Dictionary<char, char>();

            char start = 'n';
            char start1 = 'a';

            for (char i = 'a'; i <= 'm'; i++)
            {
                AtoZConverter.Add(i, start);
                start++;
            }

            for (char i = 'n'; i <= 'z'; i++)
            {
                AtoZConverter.Add(i, start1);
                start1++;
            }

            foreach (Match item in matches)
            {
                StringBuilder removePtag = new StringBuilder(item.Groups[1].Value.ToString());

               
               
               string excesscharachters = @"[^a-z\d]";
                var smallcharanddigit = Regex.Matches(removePtag.ToString(), excesscharachters)
                   .Cast<Match>().Select(a => a.Value).ToList();

                smallcharanddigit.Distinct();


                for (int i = 0; i < smallcharanddigit.Count(); i++)
                {
                    removePtag.Replace($@"{smallcharanddigit[i]}", " ");
                }

                foreach (var symbol in removePtag.ToString())
                {
                    if (AtoZConverter.ContainsKey(symbol))
                    {
                        sb.Append(AtoZConverter[symbol]);
                    }
                    else
                    {
                        try
                        {
                            int num = Convert.ToInt32(symbol.ToString());
                            sb.Append(num);
                        }
                        catch (Exception)
                        {
                            sb.Append(symbol);
                        }

                    }


                }


            }


            Console.WriteLine(Regex.Replace(sb.ToString(), "\\s+", " "));
        }
    }
}
