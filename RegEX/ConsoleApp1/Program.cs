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
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();
            var numbers = Regex.Matches(input, regex)
                .Cast<Match>().Select(a => a.Value).ToArray();
            
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
