using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SubStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string toremove = Console.ReadLine();

            string input = Console.ReadLine();


            while (true)
            {
                input  = Regex.Replace(input, toremove.ToLower(), "");
                if (!input.Contains(toremove.ToLower()))
                {
                    break;
                }
            }
            Console.WriteLine(input);
        }
    }
}
