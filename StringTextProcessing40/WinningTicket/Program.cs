using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Regex.Split(Console.ReadLine(), @"\s*,\s+").ToArray();
            
            foreach (var item in input)
            {

                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    string firsthalf = string.Empty;
                    string secondhalf = string.Empty;

                    for (int i = 0; i < item.Length; i++)
                    {

                        if (i <= 9)
                        {
                            firsthalf += item[i];
                        }
                        else
                        {
                            secondhalf += item[i];
                        }

                    }
                    string character = string.Empty;
                    if (firsthalf.Contains('@') && secondhalf.Contains('@'))
                    {
                        
                        var tryas = Regex.Match(item, @"@" + @"{6,10}");
                        if (tryas.Success == true)
                        {
                            character = "@";
                        }
                    }
                    if (firsthalf.Contains('#') && secondhalf.Contains('#'))
                    {
                        var tryas = Regex.Match(item, @"#" + @"{6,10}");
                        if (tryas.Success == true)
                        {
                            character = "#";
                        }
                    }
                    if (firsthalf.Contains('$') && secondhalf.Contains('$'))
                    {
                        var tryas = Regex.Match(item, @"$" + @"{6,10}");
                        if (tryas.Success == true)
                        {
                            character = "$";
                        }
                    }
                    if (firsthalf.Contains('^') && secondhalf.Contains('^'))
                    {
                        var tryas = Regex.Match(item, @"^" + @"{6,10}");
                        if (tryas.Success == true)
                        {
                            character = "^";
                        }
                    }

                    var regexa = Regex.Matches(item, $@"\{character}" + @"{6,10}").Cast<Match>().ToArray();
                    if (regexa.Length == 2)
                    {
                        if (regexa[0].Length >= 6 && regexa[0].Length <= 9 || regexa[1].Length >= 6 && regexa[1].Length <= 9)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", item, Math.Min(regexa[0].Length, regexa[1].Length), character);
                        }
                        else if (regexa[0].Length == 10 && regexa[1].Length == 10)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", item, 10, character);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", item);
                    }

                }

            }

        }
    }
}
