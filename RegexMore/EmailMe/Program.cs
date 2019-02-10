using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"(.+)@(.+)";

            var match = Regex.Match(input, pattern);



            string secondMatch = match.Groups[2].Value;
            string firstMatch = match.Groups[1].Value;
            long sumFirst = 0;
            long sumSecond = 0;
            foreach (var item in secondMatch)
            {
                sumSecond += Convert.ToInt64(item);

            }
            foreach (var item in firstMatch)
            {
                sumFirst += Convert.ToInt64(item);
            }

            if (sumFirst - sumSecond >= 0)
            {
                
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }



        }
    }
}
