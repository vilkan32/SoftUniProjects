using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CaptureMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(\d{2})([-.\/])([A-z][a-z]{2})\2(\d{4})\b";
            string input = Console.ReadLine();
            string[] numbers = Regex.Matches(input, regex)
                .Cast<Match>().Select(a => a.Value).ToArray();
            
            foreach (string item in numbers)
            {
                string[] Splitter = item.Split(new char[] { '-', '.', '\\', '/' });
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", Splitter[0], Splitter[1], Splitter[2]);
            }

        }
    }
}
