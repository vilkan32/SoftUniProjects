using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string pattern = @"([^&=?]+)=([^&=?]+)";
            
            List<Dictionary<string, List<string>>> Output = new List<Dictionary<string, List<string>>>();
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var matches = Regex.Matches(input, pattern);
                Dictionary<string, List<string>> LeftsideRightside = new Dictionary<string, List<string>>();
                foreach (var item in matches)
                {
                    string[] SplitItem = item.ToString().Split('=');

                    StringBuilder leftside = new StringBuilder(SplitItem[0]);
                    leftside.Replace("%20", " ");
                    leftside.Replace("+", " ");
                   
                    StringBuilder rightside = new StringBuilder(SplitItem[1]);
                 
                    rightside.Replace("%20", " ");
                    rightside.Replace("+", " ");
                   
                    string resultfromtheright = rightside.ToString();
                    string resultfromtheleft = leftside.ToString();
                   

                    if (resultfromtheleft.Contains(" "))
                    {
                        string[] result = resultfromtheleft.Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries);
                        resultfromtheleft = string.Join(" ", result);

                    }

                    if (resultfromtheright.Contains(" "))
                    {

                        string[] result = resultfromtheright.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        resultfromtheright = string.Join(" ", result);
                    }


                    if (!LeftsideRightside.ContainsKey(resultfromtheleft))
                    {
                        LeftsideRightside.Add(resultfromtheleft, new List<string>());
                        LeftsideRightside[resultfromtheleft].Add(resultfromtheright);
                    }
                    else
                    {
                        LeftsideRightside[resultfromtheleft].Add(resultfromtheright);
                    }
                   
                }

                Output.Add(LeftsideRightside);
            }

            foreach (var item in Output)
            {
                foreach (var Keyvalpair in item)
                {
                    Console.Write(Keyvalpair.Key + "=" + "[" + string.Join(", ", Keyvalpair.Value) + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
