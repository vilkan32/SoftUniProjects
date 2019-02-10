using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<string> ListOfGoers = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^(\w+) is going!$";

                var matchforgo = Regex.Match(input, pattern);
                var matchnotgo = Regex.Match(input, @"^(\w+) is not going!$");

                if (matchforgo.Success == true)
                {
                    if (ListOfGoers.Contains(matchforgo.Groups[1].Value))
                    {
                        Console.WriteLine("{0} is already in the list!", matchforgo.Groups[1].Value);
                    }
                    else
                    {
                        ListOfGoers.Add(matchforgo.Groups[1].Value);
                    }
                }
                else if (matchnotgo.Success == true)
                {
                    if (ListOfGoers.Contains(matchnotgo.Groups[1].Value))
                    {
                        ListOfGoers.Remove(matchnotgo.Groups[1].Value);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", matchnotgo.Groups[1].Value);
                    }
                }
            }

            Console.WriteLine(string.Join("\r\n", ListOfGoers));
        }
    }
}
