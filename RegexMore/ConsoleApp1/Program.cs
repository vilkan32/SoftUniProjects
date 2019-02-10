using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([0]+)";
            string patternone = @"([1]+)";
            string input = Console.ReadLine();
            List<string> Input = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string output = "";
            for (int i = 0; i < Input.Count(); i++)
            {
                var match = Regex.Matches(Input[i], pattern); // match zero
                var newmatch = Regex.Matches(Input[i], patternone); // match one 
                int zeroesresult = 0;
                int zerosequencelength = 0;
                int onesresult = 0;
                int onesequencelength = 0;
                foreach (var zeroes in match)
                {
                    if (zeroes.ToString().Length == 1)
                    {
                        zeroesresult += 3;
                    }
                    else if (zeroes.ToString().Length > 1)
                    {
                        for (int x = 0; x < zeroes.ToString().Length; x++)
                        {
                            zerosequencelength++;
                            zeroesresult += 3;
                        }
                    }
                }
                foreach (var ones in newmatch)
                {
                    if (ones.ToString().Length == 1)
                    {
                        onesresult += 5;
                    }
                    else if (ones.ToString().Length > 1)
                    {
                        for (int x = 0; x < ones.ToString().Length; x++)
                        {
                            onesequencelength++;
                            onesresult += 5;
                        }
                    }
                }

                char charascii = Convert.ToChar(onesresult + zeroesresult + onesequencelength + zerosequencelength);
                output += charascii;
            }

            Console.WriteLine(output);

        }
    }
}
