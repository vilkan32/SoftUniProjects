using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a( |)(href=.*)>(.*)<\/a>";
            List<string> InputLines = new List<string>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToString() == "end")
                {
                    break;
                }
                else
                {
                    InputLines.Add(input);
                }
                
            }

            string alreadyreplaces = "";
            string itemtoreplace = "";
            foreach (var item in InputLines)
            {
                var match = Regex.Matches(item, pattern);
                if (match.Count == 1)
                {
                    foreach (Match items in match)
                    {
                  var a = Regex.Replace(item, pattern, m => "[URL " + m.Groups[2].Value + "]" + m.Groups[3].Value + "[/URL]");

                        alreadyreplaces = a;
                        itemtoreplace = item;
                        break;
                    }
                } 
            }
            int index = InputLines.IndexOf(itemtoreplace);
            InputLines[index] = alreadyreplaces;
            foreach (var item in InputLines)
            {
                Console.WriteLine(item);
            }
        }
    }
}
