using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string input = Console.ReadLine();
            
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            
            var regex = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToArray();
            Dictionary<long, List<string>> OutputDict = new Dictionary<long, List<string>>();
            List<string> AddinDict = new List<string>();
            for (int i = 0; i < regex.Count(); i++)
            {                                                  
                    AddinDict.Add(regex[i]);
             
                if (AddinDict.Count() == 2)
                {
                    long dictkey = AddinDict[0].Count() + AddinDict[1].Count();
                    if (!OutputDict.ContainsKey(dictkey))
                    {
                        OutputDict.Add(dictkey, AddinDict);
                        AddinDict = new List<string>();
                        AddinDict.Add(regex[i]);
                    }
                    else
                    {
                        AddinDict = new List<string>();
                        AddinDict.Add(regex[i]);
                    }
                }
            }

            var output = OutputDict.Keys.ToArray();

            Console.WriteLine(string.Join("\r\n", OutputDict[output.Max()]));


        }
    }
}
