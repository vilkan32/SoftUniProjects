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
            List<char> input = Console.ReadLine().ToList();
            string required = "";
            foreach (var item in input)
            {
                required += item.ToString();
            }
           var something = input.Distinct();

            foreach (var item in something)
            {

                required = Regex.Replace(required, $@"{item}+", $"{item}");

            }
            Console.WriteLine(required);
        }
    }
}
