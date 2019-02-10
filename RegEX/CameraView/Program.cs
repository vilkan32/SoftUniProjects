using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = '{';
            char second = '}';
            int[] InputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();           
            string pattern = @"([|][<](\w){" + InputNumbers[0].ToString()+ "})" + @"((\w){0," + InputNumbers[1] + @"})";

            var matches = Regex.Matches(input, pattern)
                .Cast<Match>().Select(a => a.Groups[3]).ToArray();
            List<string> Matchedmaterial = new List<string>();

            foreach (var item in matches)
            {
                Matchedmaterial.Add(item.Value.ToString());
            }

            Console.WriteLine(string.Join(", ", Matchedmaterial));

        }
    }
}
