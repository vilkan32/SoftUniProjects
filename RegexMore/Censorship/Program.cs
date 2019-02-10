using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string banWord = Console.ReadLine();

            string input = Console.ReadLine();

            var matchandReplace = Regex.Replace(input, banWord, new string('*', banWord.Length));

            Console.WriteLine(matchandReplace.ToString());


        }
    }
}
