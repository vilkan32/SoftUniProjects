using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractPersonsInformation
{
    class Program
    {
        static void Main(string[] args)
        {

          

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var name = Regex.Match(input, @"\@([A-Za-z]+)\|");
                var age = Regex.Match(input, @"\#([0-9]+)\*");

                Console.WriteLine("{0} is {1} years old.", name.Groups[1], age.Groups[1]);
            }


        }
    }
}
