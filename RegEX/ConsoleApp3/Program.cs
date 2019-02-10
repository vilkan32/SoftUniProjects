using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> SplitInput = input.ToList();
            string buldthepattern = "";
            for (int i = 0; i < SplitInput.Count; i++)
            {
                buldthepattern += $"[{SplitInput[i].ToString()}]";
            }
            string pattern = $@"\b{buldthepattern}\b";
            List<string> Input = Console.ReadLine().Split(new char[] { '!', '?' ,'.'},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> MathesToOutput = new List<string>();
            foreach (string item in Input)
            {

                var match = Regex.Matches(item, pattern);
                if (match.Count > 0)
                {
                    MathesToOutput.Add(item);
                }

            }


            Console.WriteLine(string.Join("\r\n", MathesToOutput));


        }
    }
}
