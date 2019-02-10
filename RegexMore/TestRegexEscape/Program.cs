using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace TestRegexEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            while (true)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();

                string pattern = $@"\{arr[0]}" + @"{" + arr[1] + ",}";

                var match = Regex.Match(input, pattern);
                if (match.Success == true)
                {

                    var asdasd = match.Index;
                    var asdsd = match.Length;

                    Console.WriteLine("Hideout found at index {0} and it is with size {1}!", asdasd, asdsd);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
