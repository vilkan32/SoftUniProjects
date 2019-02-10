using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            bool length = true;
            bool nomatch = true;
            foreach (var item in input)
            {
                var regex = Regex.Match(item, @"[^A-Za-z0-9-_]");
                if (item.Length >= 3 && item.Length <= 16)
                {
                    length = true;
                }
                else
                {
                    length = false;
                }

                if (regex.Success == true)
                {
                    nomatch = false;
                }
                else
                {
                    nomatch = true;
                }

                if (length == true && nomatch == true)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
